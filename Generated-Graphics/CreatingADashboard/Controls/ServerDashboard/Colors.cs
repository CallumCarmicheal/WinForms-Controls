using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADashboard.Controls.ServerDashboard {
    class Colors {

        public class Form {
            public static Color
                Background   = Color.FromArgb(0x28, 0x29, 0x2C);
        }

        public class TabControl {
            public static Color
                Background   = Color.FromArgb(40, 41, 44),
                TabBar       = Color.FromArgb(44, 44, 49),
                ItmActive    = Color.FromArgb(0x2C, 0xB7, 0xB8);
        }


        public class Button {
            public static Color
                Background  = Color.FromArgb(40, 41, 44),
                Highlighted = Color.FromArgb(0x48, 0x48, 0x4B),
                Selected    = Color.FromArgb(0x19, 0x1A, 0x1D),
                FontColor   = Color.FromArgb(0x3A, 0x39, 0x41); // #3A3941
        }
    }
}
