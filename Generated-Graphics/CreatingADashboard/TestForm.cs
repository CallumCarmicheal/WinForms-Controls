using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard {
    public partial class TestForm : Controls.ServerDashboard.DashboardForm {
        public TestForm() {
            InitializeComponent();
        }

        private void generatedButton1_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
        }
    }
}
