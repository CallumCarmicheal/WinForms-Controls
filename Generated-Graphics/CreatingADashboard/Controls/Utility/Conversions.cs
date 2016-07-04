using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADashboard.Controls.Utility {
    class Conversions {
        public static Color FromHex(string hex) {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }
    }
}
