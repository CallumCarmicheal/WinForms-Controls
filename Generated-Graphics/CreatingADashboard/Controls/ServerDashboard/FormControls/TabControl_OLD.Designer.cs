namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    partial class TabControl_OLD {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pnlTabs.Controls.Add(this.panel2);
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(65, 282);
            this.pnlTabs.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(66, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 282);
            this.panel2.TabIndex = 1;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.pnlTabs);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(482, 282);
            this.Resize += new System.EventHandler(this.TabControl_Resize);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Panel panel2;
    }
}
