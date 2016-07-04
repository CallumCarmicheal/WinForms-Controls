using System;
using System.Drawing;
using System.Drawing.Text;

namespace CreatingADashboard.Controls.ServerDashboard.Fonts {
    class Handler {
        private static bool _ind = false;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        /// <summary>
        /// Store the icon font in a static variable to reuse between icons
        /// </summary>
        private static readonly PrivateFontCollection Fonts = new PrivateFontCollection();

        /// <summary>
        /// Loads the icon font from the resources.
        /// </summary>
        private static void InitialiseFont() {
            try {
                unsafe
                {
                    fixed (byte* pFontData = Properties.Resources.fontawesome_webfont)
                    {
                        uint dummy = 0;
                        Fonts.AddMemoryFont((IntPtr)pFontData, Properties.Resources.fontawesome_webfont.Length);
                        AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.fontawesome_webfont.Length, IntPtr.Zero, ref dummy);
                    }
                }
            } catch (Exception ex) {
                // log?
            }
        }

        /// <summary>
        /// Returns a font instance using the resource icon font.
        /// </summary>
        /// <param name="size">The size of the font in points.</param>
        /// <returns>A new System.Drawing.Font instance</returns>
        public static System.Drawing.Font GetIconFont(float size) {
            if (!_ind)
                InitialiseFont();
            return new System.Drawing.Font(Fonts.Families[0], size, GraphicsUnit.Point);
        }

        /// <summary>
        /// Returns a new font that fits the specified character into the allocated space.
        /// </summary>
        /// <param name="g">The graphics object.</param>
        /// <param name="graphicString">The string (icon character) to render as a graphic.</param>
        /// <param name="containerWidth">Width of the container.</param>
        /// <param name="maxFontSize">Size of the max font.</param>
        /// <param name="minFontSize">Size of the min font.</param>
        /// <param name="smallestOnFail">if set to <c>true</c> [smallest on fail].</param>
        /// <returns></returns>
        public static System.Drawing.Font GetAdjustedFont(Graphics g, string graphicString, int containerWidth, int maxFontSize, int minFontSize, bool smallestOnFail) {
            if(!_ind) 
                InitialiseFont();
            

            for (double adjustedSize = maxFontSize; adjustedSize >= minFontSize; adjustedSize = adjustedSize - 0.5) {
                System.Drawing.Font testFont = GetIconFont((float)adjustedSize);
                // Test the string with the new size
                SizeF adjustedSizeNew = g.MeasureString(graphicString, testFont);
                if (containerWidth > Convert.ToInt32(adjustedSizeNew.Width)) {
                    // Fits! return it
                    return testFont;
                }
            }

            // Could not find a font size
            // return min or max or maxFontSize?
            return GetIconFont(smallestOnFail ? minFontSize : maxFontSize);
        }
    }
}
