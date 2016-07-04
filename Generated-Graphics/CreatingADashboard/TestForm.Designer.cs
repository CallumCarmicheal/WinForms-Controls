namespace CreatingADashboard {
    partial class TestForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.generatedTabControl1 = new CreatingADashboard.Controls.ServerDashboard.FormControls.GeneratedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generatedButton1 = new CreatingADashboard.Controls.ServerDashboard.FormControls.GeneratedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.generatedTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatedTabControl1
            // 
            this.generatedTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.generatedTabControl1.Controls.Add(this.tabPage1);
            this.generatedTabControl1.Controls.Add(this.tabPage2);
            this.generatedTabControl1.Controls.Add(this.tabPage3);
            this.generatedTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.generatedTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedTabControl1.Icons.Add(((CreatingADashboard.Controls.ServerDashboard.FormControls.IconType)(resources.GetObject("generatedTabControl1.Icons"))));
            this.generatedTabControl1.Icons.Add(((CreatingADashboard.Controls.ServerDashboard.FormControls.IconType)(resources.GetObject("generatedTabControl1.Icons1"))));
            this.generatedTabControl1.Icons.Add(((CreatingADashboard.Controls.ServerDashboard.FormControls.IconType)(resources.GetObject("generatedTabControl1.Icons2"))));
            this.generatedTabControl1.ItemSize = new System.Drawing.Size(55, 65);
            this.generatedTabControl1.ItmSize = new System.Drawing.Size(55, 65);
            this.generatedTabControl1.Location = new System.Drawing.Point(0, 0);
            this.generatedTabControl1.Multiline = true;
            this.generatedTabControl1.Name = "generatedTabControl1";
            this.generatedTabControl1.SelectedIndex = 0;
            this.generatedTabControl1.Size = new System.Drawing.Size(673, 309);
            this.generatedTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.generatedTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.tabPage1.Controls.Add(this.generatedButton1);
            this.tabPage1.Location = new System.Drawing.Point(69, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // generatedButton1
            // 
            this.generatedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedButton1.Location = new System.Drawing.Point(6, 8);
            this.generatedButton1.Name = "generatedButton1";
            this.generatedButton1.Size = new System.Drawing.Size(139, 287);
            this.generatedButton1.TabIndex = 0;
            this.generatedButton1.Text = "Get Time left";
            this.generatedButton1.UseVisualStyleBackColor = true;
            this.generatedButton1.Click += new System.EventHandler(this.generatedButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.tabPage2.Location = new System.Drawing.Point(69, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(69, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 309);
            this.Controls.Add(this.generatedTabControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.generatedTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ServerDashboard.FormControls.GeneratedTabControl generatedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.ServerDashboard.FormControls.GeneratedButton generatedButton1;
    }
}