using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    class GeneratedButton : Button {

        public GeneratedButton() {
            FlatStyle = FlatStyle.Flat;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent.BackColor);

            var rect    = DisplayRectangle;
            rect.Height = rect.Height - 1;
            rect.Width  = rect.Width - 1;

            var rad     = this.Height / 2 - 3;
            var path    = GraphicsUtil.RoundedRect(rect, rad);
            var pen     = new Pen (Colors.Button.FontColor, 2.1f);
            g.DrawPath(pen, path);

            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            /*var sf = g.MeasureString(Text, this.Font, this.Width);
            var ThePoint = new Point() {
                X = (int)((this.Width / 2) - (sf.Width / 2)),
                Y = (int)((this.Height / 2) / 2 - (sf.Height / 2))
            };

            g.DrawString(Text, Font,
                      new SolidBrush(Colors.Button.FontColor), ThePoint);*/

            GraphicsUtil.DrawStringCenter(g, Text, Font, Color.White, rect);
        }


    }
}
