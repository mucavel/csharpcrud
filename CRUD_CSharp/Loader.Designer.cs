namespace CRUD_CSharp
{
    partial class Loader
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
            this.components = new System.ComponentModel.Container();
            this.stockLabel = new System.Windows.Forms.Label();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GunaProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SuspendLayout();
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.ForeColor = System.Drawing.Color.White;
            this.stockLabel.Location = new System.Drawing.Point(92, 91);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(290, 31);
            this.stockLabel.TabIndex = 0;
            this.stockLabel.Text = "GESTOR DE STOCK";
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimerTick);
            // 
            // GunaProgressBar
            // 
            this.GunaProgressBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.GunaProgressBar.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.GunaProgressBar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.GunaProgressBar.Location = new System.Drawing.Point(1, 258);
            this.GunaProgressBar.Name = "GunaProgressBar";
            this.GunaProgressBar.ProgressColor = System.Drawing.Color.White;
            this.GunaProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.GunaProgressBar.Size = new System.Drawing.Size(475, 10);
            this.GunaProgressBar.TabIndex = 2;
            this.GunaProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.GunaProgressBar);
            this.Controls.Add(this.stockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ProgressBar GunaProgressBar;
    }
}