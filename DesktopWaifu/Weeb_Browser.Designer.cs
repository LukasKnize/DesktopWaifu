namespace DesktopWaifu {
    partial class Weeb_Browser {
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
            this.WBCore = new System.Windows.Forms.WebBrowser();
            this.open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WBCore
            // 
            this.WBCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBCore.Location = new System.Drawing.Point(0, 0);
            this.WBCore.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBCore.Name = "WBCore";
            this.WBCore.Size = new System.Drawing.Size(893, 501);
            this.WBCore.TabIndex = 0;
            // 
            // open
            // 
            this.open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open.Location = new System.Drawing.Point(767, 457);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(114, 37);
            this.open.TabIndex = 1;
            this.open.Text = "Open In Browser";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Weeb_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 501);
            this.Controls.Add(this.open);
            this.Controls.Add(this.WBCore);
            this.Name = "Weeb_Browser";
            this.Text = "Weeb_Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBCore;
        private System.Windows.Forms.Button open;
    }
}