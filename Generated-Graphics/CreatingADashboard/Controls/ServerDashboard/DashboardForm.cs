using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard {
    public partial class DashboardForm : System.Windows.Forms.Form {
        public DashboardForm() {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; 
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            var g                   = e.Graphics;
            g.InterpolationMode     = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality    = CompositingQuality.HighQuality;
            g.SmoothingMode         = SmoothingMode.HighQuality;

            SolidBrush brush = new SolidBrush(Colors.Form.Background);

            g.FillRectangle(brush, this.ClientRectangle);
            brush.Dispose();
        }
    }
}
