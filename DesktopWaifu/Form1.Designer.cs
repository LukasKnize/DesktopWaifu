namespace DesktopWaifu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayField = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            this.TextField = new System.Windows.Forms.RichTextBox();
            this.EnterField = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.navBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayField)).BeginInit();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayField
            // 
            this.DisplayField.Location = new System.Drawing.Point(16, 55);
            this.DisplayField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayField.Name = "DisplayField";
            this.DisplayField.Size = new System.Drawing.Size(499, 350);
            this.DisplayField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayField.TabIndex = 0;
            this.DisplayField.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Submit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Submit.Location = new System.Drawing.Point(1093, 411);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 30);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TextField
            // 
            this.TextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.TextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextField.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.TextField.Location = new System.Drawing.Point(572, 55);
            this.TextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextField.Name = "TextField";
            this.TextField.ReadOnly = true;
            this.TextField.Size = new System.Drawing.Size(641, 350);
            this.TextField.TabIndex = 2;
            this.TextField.Text = "";
            // 
            // EnterField
            // 
            this.EnterField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.EnterField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.EnterField.Location = new System.Drawing.Point(572, 411);
            this.EnterField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterField.Multiline = true;
            this.EnterField.Name = "EnterField";
            this.EnterField.Size = new System.Drawing.Size(507, 30);
            this.EnterField.TabIndex = 3;
            this.EnterField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterField_KeyDown);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Previous.Location = new System.Drawing.Point(16, 411);
            this.Previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(165, 31);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "<";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Next.Location = new System.Drawing.Point(349, 411);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(165, 31);
            this.Next.TabIndex = 5;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.save.Location = new System.Drawing.Point(204, 411);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 31);
            this.save.TabIndex = 6;
            this.save.Text = "save image";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.closeButton);
            this.navBar.Location = new System.Drawing.Point(0, -1);
            this.navBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1235, 49);
            this.navBar.TabIndex = 7;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1160, 16);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 21);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1191, 16);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 21);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1229, 474);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.EnterField);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DisplayField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Desktop Waifu";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayField)).EndInit();
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayField;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox TextField;
        private System.Windows.Forms.TextBox EnterField;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
    }
}

