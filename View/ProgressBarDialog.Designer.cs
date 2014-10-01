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
            this.labelGenerateLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGenerateLevel.Location = new System.Drawing.Point(6, 33);
            this.labelGenerateLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerateLevel.Name = "labelGenerateLevel";
            this.labelGenerateLevel.Size = new System.Drawing.Size(93, 13);
            this.labelGenerateLevel.TabIndex = 8;
            this.labelGenerateLevel.Text = "Generating level...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 6);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(496, 25);
            this.progressBar.TabIndex = 7;
            // 
            // ProgressBarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(508, 51);
            this.Controls.Add(this.labelGenerateLevel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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