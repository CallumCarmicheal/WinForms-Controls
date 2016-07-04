using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    public partial class TabIcon : UserControl {
        public Color 
                // Background
                     col_Bg_Default  = Color.FromArgb(0x2C, 0x2C, 0x31),
                     col_Bg_Selected = Color.FromArgb(0x2C, 0xB7, 0xB8),

                // Icon
                     col_Icon_Default  = Color.White,
                     col_Icon_Disabled = Color.FromArgb(0x71, 0x71, 0x74), // #717174
                     // ----------------------------------
                     col_Icon_Hovered  = Color.FromArgb(0xA8, 0xA8, 0xAB),  // 0x71+0x45 = 0xB8, 0x74+0x47 = 0xBB
                     col_Icon_Selected = Color.White;


        private void setIconColor(Color col) {
            this.iconButton1.ActiveColor   = col;
            this.iconButton1.InActiveColor = col;
        }

        private void TabIcon_Click(object sender, EventArgs e) {
            Active = !Active;
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            Active = !Active;
        }

        private bool _hover = false;
        private bool _active = false;

        [Category("Tab Properties")]
        [Description("States if the tab is active or not (VISUAL)")]
        public bool Active {
            get {
                return _active;
            } set {
                _active   = value;
                BackColor = value ? col_Bg_Selected : col_Bg_Default;

                if (_active) {
                    this.iconButton1.ActiveColor = col_Icon_Selected;
                    this.iconButton1.InActiveColor = col_Icon_Selected;
                } else {
                    this.iconButton1.ActiveColor = col_Icon_Hovered;
                    this.iconButton1.InActiveColor = col_Icon_Default;
                }
            }
        }

        [Category("Tab Properties")]
        [Description("States if the tab is active or not (VISUAL)")]
        public FontAwesomeIcons.IconType Icon {
            get {
                return iconButton1.IconType;
            }
            set {
                iconButton1.IconType = value;
            }
        }

        public TabIcon() {
            InitializeComponent();
        }
    }
}
