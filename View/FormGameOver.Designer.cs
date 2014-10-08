namespace WarGame.View
{
    partial class FormGameOver
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
            this.labelGameOverMessage = new System.Windows.Forms.Label();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.buttonToMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGameOverMessage
            // 
            this.labelGameOverMessage.AutoSize = true;
            this.labelGameOverMessage.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOverMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameOverMessage.Location = new System.Drawing.Point(353, 600);
            this.labelGameOverMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGameOverMessage.Name = "labelGameOverMessage";
            this.labelGameOverMessage.Size = new System.Drawing.Size(358, 46);
            this.labelGameOverMessage.TabIndex = 0;
            this.labelGameOverMessage.Text = "Killed in action!";
            // 
            // buttonRetry
            // 
            this.buttonRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetry.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRetry.Location = new System.Drawing.Point(907, 678);
            this.buttonRetry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(150, 61);
            this.buttonRetry.TabIndex = 1;
            this.buttonRetry.Text = "Retry";
            this.buttonRetry.UseVisualStyleBackColor = true;
            // 
            // buttonToMenu
            // 
            this.buttonToMenu.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenu.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToMenu.Location = new System.Drawing.Point(15, 678);
            this.buttonToMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(150, 61);
            this.buttonToMenu.TabIndex = 2;
            this.buttonToMenu.Text = "Exit";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WarGame.Properties.Resources.KIA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1072, 754);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.labelGameOverMessage);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormGameOver";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOverMessage;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Button buttonToMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}