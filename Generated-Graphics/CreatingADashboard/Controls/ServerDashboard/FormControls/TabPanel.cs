using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    public class TabPanel : Panel {
        [Category("Tab Properties")]
        [Description("States if the tab is active or not (VISUAL)")]
        public FontAwesomeIcons.IconType Icon { get; set; }
    }
}
