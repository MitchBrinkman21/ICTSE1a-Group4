namespace WarGame.View
{
    partial class ProgressBarDialog
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
            this.labelGenerateLevel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelGenerateLevel
            // 
            this.labelGenerateLevel.AutoSize = true;
            this.labelGenerateLevel.Location = new System.Drawing.Point(12, 63);
            this.labelGenerateLevel.Name = "labelGenerateLevel";
            this.labelGenerateLevel.Size = new System.Drawing.Size(170, 25);
            this.labelGenerateLevel.TabIndex = 8;
            this.labelGenerateLevel.Text = "Generate level...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(993, 48);
            this.progressBar.TabIndex = 7;
            // 
            // ProgressBarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 99);
            this.Controls.Add(this.labelGenerateLevel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProgressBarDialog";
            this.Text = "Please wait a moment...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenerateLevel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}