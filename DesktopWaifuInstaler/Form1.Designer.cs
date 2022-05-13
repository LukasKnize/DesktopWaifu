namespace DesktopWaifuInstaler
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
            this.components = new System.ComponentModel.Container();
            this.MainText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingBarTimer = new System.Windows.Forms.Timer(this.components);
            this.loaderBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.ForeColor = System.Drawing.Color.White;
            this.MainText.Location = new System.Drawing.Point(12, 22);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(125, 13);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Updating DeskTopWaifu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait, it will take just few seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "If instalation failed, run DesktopWaifuInstaler.exe or contact developers on http" +
    "s://github.com/LukasKnize/DesktopWaifu";
            // 
            // loadingBarTimer
            // 
            this.loadingBarTimer.Tick += new System.EventHandler(this.LoadingBarTimer_Tick);
            // 
            // loaderBar
            // 
            this.loaderBar.Location = new System.Drawing.Point(142, 120);
            this.loaderBar.Name = "loaderBar";
            this.loaderBar.Size = new System.Drawing.Size(357, 19);
            this.loaderBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(693, 177);
            this.ControlBox = false;
            this.Controls.Add(this.loaderBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer loadingBarTimer;
        private System.Windows.Forms.ProgressBar loaderBar;
    }
}

