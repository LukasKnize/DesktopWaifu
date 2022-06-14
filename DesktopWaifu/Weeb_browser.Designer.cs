﻿namespace DesktopWaifu
{
    partial class Weeb_browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.navBar = new System.Windows.Forms.Panel();
            this.devTools = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.URLInput = new System.Windows.Forms.RichTextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.WebBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1200, 15);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 21);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1231, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 21);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // navBar
            // 
            this.navBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navBar.Controls.Add(this.devTools);
            this.navBar.Controls.Add(this.maximizeButton);
            this.navBar.Controls.Add(this.Next);
            this.navBar.Controls.Add(this.Back);
            this.navBar.Controls.Add(this.URLInput);
            this.navBar.Controls.Add(this.OpenButton);
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.closeButton);
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1267, 62);
            this.navBar.TabIndex = 8;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            // 
            // devTools
            // 
            this.devTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.devTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devTools.ForeColor = System.Drawing.Color.White;
            this.devTools.Image = global::DesktopWaifu.Properties.Resources.tools_fill;
            this.devTools.Location = new System.Drawing.Point(841, 14);
            this.devTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devTools.Name = "devTools";
            this.devTools.Size = new System.Drawing.Size(59, 30);
            this.devTools.TabIndex = 13;
            this.devTools.UseVisualStyleBackColor = false;
            this.devTools.Click += new System.EventHandler(this.DevTools_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(1169, 15);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(23, 21);
            this.maximizeButton.TabIndex = 12;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Image = global::DesktopWaifu.Properties.Resources.arrow_go_forward_fill;
            this.Next.Location = new System.Drawing.Point(71, 14);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(59, 30);
            this.Next.TabIndex = 11;
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click_1);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Image = global::DesktopWaifu.Properties.Resources.arrow_go_back_fill1;
            this.Back.Location = new System.Drawing.Point(4, 14);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 30);
            this.Back.TabIndex = 10;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // URLInput
            // 
            this.URLInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.URLInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.URLInput.Location = new System.Drawing.Point(196, 14);
            this.URLInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.URLInput.MaxLength = 150;
            this.URLInput.Multiline = false;
            this.URLInput.Name = "URLInput";
            this.URLInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.URLInput.Size = new System.Drawing.Size(517, 30);
            this.URLInput.TabIndex = 9;
            this.URLInput.Text = "";
            this.URLInput.WordWrap = false;
            this.URLInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLInput_KeyDown);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.Color.White;
            this.OpenButton.Image = global::DesktopWaifu.Properties.Resources.search_line;
            this.OpenButton.Location = new System.Drawing.Point(720, 14);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(113, 30);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // WebBrowser
            // 
            this.WebBrowser.ActivateBrowserOnCreation = false;
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(0, 62);
            this.WebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(1267, 738);
            this.WebBrowser.TabIndex = 9;
            this.WebBrowser.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.ChromiumWebBrowser1_AddressChanged);
            // 
            // Weeb_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 800);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Weeb_browser";
            this.Text = "Weeb browser";
            this.Load += new System.EventHandler(this.Weeb_browser_Load);
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button minimizeButton;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Panel navBar;
        private CefSharp.WinForms.ChromiumWebBrowser WebBrowser;
        private System.Windows.Forms.Button OpenButton;
        internal System.Windows.Forms.RichTextBox URLInput;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        internal System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button devTools;
    }
}