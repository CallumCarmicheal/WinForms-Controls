using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    [Serializable]
    public class IconType {
        public IconType() {
            this._ico = FontAwesomeIcons.IconType.CircleThin;
            this._ics = _ico.ToString();
        }

        private FontAwesomeIcons.IconType _ico;
        private string _ics;

        public string Icon_str {
            get { return _ics; }
            set {
                FontAwesomeIcons.IconType tmp;

                try {
                    tmp = Extensions.Enum<FontAwesomeIcons.IconType>.Parse(value);
                    _ico = tmp;
                    _ics = value;
                } catch (Exception ex) {
                    //MessageBox.Show("Failed to cast string to enum\nString: " + value + "\n\nError: " + ex.Message);
                    tmp = _ico;
                    _ics = _ico.ToString();
                }
            }
        } //*/

        public FontAwesomeIcons.IconType GetIcon() {
            return _ico;
        }
        
        public FontAwesomeIcons.IconType Icon {
            get { return _ico; }
            set {
                _ico = value;
                _ics = _ico.ToString();
            }
        } //*/
    }
}
