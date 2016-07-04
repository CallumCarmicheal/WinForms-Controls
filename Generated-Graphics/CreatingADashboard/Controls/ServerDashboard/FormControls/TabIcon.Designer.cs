namespace CreatingADashboard.Controls.ServerDashboard.FormControls {
    partial class TabIcon {
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
            this.iconButton1 = new FontAwesomeIcons.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconType = FontAwesomeIcons.IconType.Star;
            this.iconButton1.InActiveColor = System.Drawing.Color.White;
            this.iconButton1.Location = new System.Drawing.Point(16, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 49);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.TabStop = false;
            this.iconButton1.ToolTipText = null;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // TabIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.iconButton1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(65, 55);
            this.MinimumSize = new System.Drawing.Size(65, 55);
            this.Name = "TabIcon";
            this.Size = new System.Drawing.Size(65, 55);
            this.Click += new System.EventHandler(this.TabIcon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesomeIcons.IconButton iconButton1;
    }
}
