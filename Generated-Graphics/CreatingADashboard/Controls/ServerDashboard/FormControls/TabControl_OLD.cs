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
    public partial class TabControl_OLD : UserControl {
        private List<TabPanel> panels = new List<TabPanel>();

        public TabControl_OLD() {
            InitializeComponent();
        }

        private void TabControl_Resize(object sender, EventArgs e) {
            //int newHC = Math.Floor((this.Height / 65));
            //int newH  = 65 * newWidthCount + 1;

            double val    = this.Height / 55;
            double count  = Math.Round(val, 0);
            double result = (count == 0 ? 55 : count * 55);
            
            this.Height   = (int)result;
        }

        [Category("Tab Properties")]
        [Description("States if the tab is active or not (VISUAL)")]
        [Browsable(true)]
        //[Editor()]
        [EditorAttribute(typeof(UIEditors.TabControl), typeof(System.Windows.Forms.Form))]
        //[EditorBrowsable()]
        public List<TabPanel> Tabs {
            get { return panels; }
            set { }
        }
    }
}
