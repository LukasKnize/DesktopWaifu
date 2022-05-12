namespace DesktopWaifu
{
    partial class DesktopWaifu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopWaifu));
            this.Display = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.navBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(16, 55);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(499, 350);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display.TabIndex = 0;
            this.Display.TabStop = false;
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
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 30);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.CausesValidation = false;
            this.Output.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Output.Location = new System.Drawing.Point(572, 55);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Output.Size = new System.Drawing.Size(641, 350);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Input.Location = new System.Drawing.Point(572, 411);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(507, 16);
            this.Input.TabIndex = 3;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterField_KeyDown);
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
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.Save.Location = new System.Drawing.Point(204, 411);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 31);
            this.Save.TabIndex = 6;
            this.Save.Text = "save image";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.save_Click);
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.closeButton);
            this.navBar.Location = new System.Drawing.Point(0, -1);
            this.navBar.Margin = new System.Windows.Forms.Padding(4);
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
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 21);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.Color.White;
            this.Loading.Location = new System.Drawing.Point(568, 431);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(80, 20);
            this.Loading.TabIndex = 9;
            this.Loading.Text = "Loading...";
            // 
            // DesktopWaifu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1229, 474);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DesktopWaifu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Desktop Waifu";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox Display;
        internal System.Windows.Forms.Button Submit;
        internal System.Windows.Forms.RichTextBox Output;
        internal System.Windows.Forms.TextBox Input;
        internal System.Windows.Forms.Button Previous;
        internal System.Windows.Forms.Button Next;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Panel navBar;
        internal System.Windows.Forms.Button minimizeButton;
        internal System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label Loading;
    }
}

