using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADashboard.Controls.ServerDashboard.FormControls {

    class GeneratedTabControl : System.Windows.Forms.TabControl {
        Form parent;

        public void SetParentForm(Form p) {
            parent = p;
        }

        Collection<IconType> icons = new Collection<IconType>();

        [Category("Tab Properties")]
        [Description("The icons that will be used for the tabs by tabIndex")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Collection<IconType> Icons {
            get { return icons; } 
        }

        [Category("Tab Properties")]
        [Description("Who's asking?")]
        public Size ItmSize {
            get { return ItemSize;  }
            set { ItemSize = value; }
        }

        public GeneratedTabControl() {
            //MinimumSize = new Size(100, 55);

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            DrawMode  = TabDrawMode.OwnerDrawFixed;
            ItemSize  = new System.Drawing.Size(55, 65);
            SizeMode  = TabSizeMode.Fixed;
            Alignment = TabAlignment.Left;

            var nF = new Font(Font.FontFamily, 10.25f, Font.Style);
            this.Font = nF;
        }

        protected override void OnPaint(PaintEventArgs e) {
            //base.OnPaint(e);
            e.Graphics.Clear(Colors.TabControl.Background);

            var p = new Pen(Colors.TabControl.TabBar);
            var rect = new Rectangle(0, 0, 65, Height);

            e.Graphics.DrawRectangle(p, rect);

            int x = 0;
            foreach (TabPage tbc in TabPages) {
                DrawItem(e.Graphics, x);
                x++;
            }
        }

        /*/
        protected override void OnPaintBackground(PaintEventArgs e) {
            e.Graphics.Clear(colBackground);

            var p = new Pen(colTabBar);
            var rect = new Rectangle(0, 0, 65, 55);

            e.Graphics.DrawRectangle(p, rect);
        } //*/

        private void DrawItemBackground(Graphics g, Rectangle rect, bool Active) {
            SolidBrush b;

            if (Active) {
                b = new SolidBrush(Colors.TabControl.ItmActive);
                g.FillRectangle(b, rect);
            } 
        }

        protected override void OnControlAdded(ControlEventArgs e) {
            base.OnControlAdded(e);

            // Set the background
            e.Control.BackColor = Colors.TabControl.Background;
            e.Control.MouseDown += Control_MouseDown;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e) {
            if (e.Location.Y > 30) {
                // TODO: DRAG FORM
            }
        }

        void DrawItem(Graphics g, int tabIndex) {
            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = GetTabRect(tabIndex);
            DrawItemBackground(g, _tabBounds, SelectedIndex == tabIndex);
            FontAwesomeIcons.IconType icon;

            if (icons.ElementAtOrDefault(tabIndex) != null) {
                icon = icons[tabIndex].GetIcon();

                Brush _textBrush = new SolidBrush(Color.White);
                Font _tabFont    = Fonts.Handler.GetIconFont(this.Font.SizeInPoints);

                StringFormat _stringFlags = new StringFormat();
                _stringFlags.Alignment = StringAlignment.Center;
                _stringFlags.LineAlignment = StringAlignment.Center;

                g.DrawString(
                    "" + char.ConvertFromUtf32((int)icon),
                    _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
            } else {
                // No icon
            }
        }
    }
}
