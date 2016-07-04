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
    public enum FormButton_Action {
        Minimise,
        MaximiseRestore,
        Exit
    }

    public partial class FormButton : UserControl {
        public Form parent;
        public FormButton_Action action;
        public Color[] Colors; // 0 = Normal, 1 = Highlighted, 2 = Selected

        private bool 
            mouseDown  = false,
            mouseHover = false;



        /*
        private FontAwesomeIcons.IconType
            icon_Minimise   = FontAwesomeIcons.IconType.,
            icon_Maximise   ,
            icon_Restore    ,
            icon_Close      ; //*/

        public int
            colIndex_Normal = 0,
            colIndex_Highlighted = 1,
            colIndex_Selected    = 2;

        #region Constructors

        // Uses default icons for Action
        public FormButton(Form ParentForm, FormButton_Action FormAction) {
            InitializeComponent();

            this.parent = ParentForm;
            this.action = FormAction;
            SetColors();
            SetIcon();
        }

        public FormButton(Form ParentForm, FormButton_Action FormAction, Color colNormal, Color colHighlighted, Color colSelected) {
            InitializeComponent();

            this.parent = ParentForm;
            this.action = FormAction;
            SetColors(colNormal, colHighlighted, colSelected);
            SetIcon();
        }

        #endregion

        #region Methods and Functions

        public Color getNormal()      { return Colors[colIndex_Normal]; }
        public Color getHighlighted() { return Colors[colIndex_Highlighted]; }
        public Color getSelected()    { return Colors[colIndex_Selected]; }

        public void SetColors() {
            // Default colors
            Colors = new Color[] {
                Color.FromArgb(0x28, 0x29, 0x2C), // Normal
                Color.FromArgb(0x47, 0x48, 0x4B), // Highlighted
                Color.FromArgb(0x19, 0x1A, 0x1D)  // Selected
            }; //*/

            /*/ Default test colors
            Colors = new Color[] {
                Color.FromArgb(0xFF, 0x0,  0x0),  // Normal
                Color.FromArgb(0x0,  0xFF, 0x0),  // Highlighted
                Color.FromArgb(0x0,  0x0,  0xFF)  // Selected
            }; //*/ 

            icon.BackColor = getNormal();
        }

        public void SetIcon() {
            if(action == FormButton_Action.MaximiseRestore) {
                if(parent.WindowState == FormWindowState.Normal) {
                    // Maximise
                    icon.Image = CreatingADashboard.Properties.Resources.Maximise;
                } else {
                    // Restore 
                    icon.Image = CreatingADashboard.Properties.Resources.Restore;
                }
            } else if (action == FormButton_Action.Minimise) {
                // Minimise 
                icon.Image = CreatingADashboard.Properties.Resources.Minimise;
            } else {
                // Exit 
                icon.Image = CreatingADashboard.Properties.Resources.Exit;
            }
        }

        public void SetColors(Color colNormal, Color colHighlighted, Color colSelected) {
            Colors = new Color[] { colNormal, colHighlighted, colSelected };

            icon.BackColor = getNormal();
        }

        public void SetAction(FormButton_Action act) {
            this.action = act;
        }

        #endregion

        #region Events

        private void icon_MouseUp(object sender, MouseEventArgs e)          { mouseDown = false; if (mouseHover) icon.BackColor = getHighlighted(); else icon.BackColor = getNormal(); }

        private void icon_MouseHover(object sender, EventArgs e)            { mouseHover = true; if (!mouseDown) icon.BackColor = getHighlighted(); }

        private void icon_Click(object sender, EventArgs e) {
            switch(this.action) {
            case FormButton_Action.Minimise:
                parent.WindowState = FormWindowState.Minimized;
                break;
                
            case FormButton_Action.MaximiseRestore:

                parent.WindowState = FormWindowState.Maximized;
                break;
            case FormButton_Action.Exit:
                parent.Close();
                break;
            default:
                break;
            }
        }

        private void icon_MouseLeave(object sender, EventArgs e)            { mouseHover = false; if (!mouseDown) icon.BackColor = getNormal(); }

        private void iconButton1_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; icon.BackColor = getSelected(); }

        #endregion
    }
}
