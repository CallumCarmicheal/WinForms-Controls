using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls.UIEditors {
    public class TabControl : System.ComponentModel.Design.CollectionEditor {

        public TabControl(Type t) : base(t) {

        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
            return base.EditValue(context, provider, value);
        }
    }
}
