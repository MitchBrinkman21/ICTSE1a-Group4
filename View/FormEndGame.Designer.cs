namespace WarGame.View
{
    partial class FormEndGame
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubTitle2 = new System.Windows.Forms.Label();
            this.labelSubTitle1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonHighscores = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(89, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(301, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Reached base!";
            // 
            // labelSubTitle2
            // 
            this.labelSubTitle2.AutoSize = true;
            this.labelSubTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle2.Location = new System.Drawing.Point(34, 155);
            this.labelSubTitle2.Name = "labelSubTitle2";
            this.labelSubTitle2.Size = new System.Drawing.Size(123, 25);
            this.labelSubTitle2.TabIndex = 2;
            this.labelSubTitle2.Text = "Your name:";
            // 
            // labelSubTitle1
            // 
            this.labelSubTitle1.AutoSize = true;
            this.labelSubTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle1.Location = new System.Drawing.Point(34, 108);
            this.labelSubTitle1.Name = "labelSubTitle1";
            this.labelSubTitle1.Size = new System.Drawing.Size(110, 25);
            this.labelSubTitle1.TabIndex = 1;
            this.labelSubTitle1.Text = "Your time:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(175, 108);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 25);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00.00.00";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(180, 157);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // buttonHighscores
            // 
            this.buttonHighscores.Location = new System.Drawing.Point(12, 252);
            this.buttonHighscores.Name = "buttonHighscores";
            this.buttonHighscores.Size = new System.Drawing.Size(97, 28);
            this.buttonHighscores.TabIndex = 5;
            this.buttonHighscores.Text = "Highscores";
            this.buttonHighscores.UseVisualStyleBackColor = true;
            this.buttonHighscores.Click += new System.EventHandler(this.buttonHighscores_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(346, 252);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 28);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(39, 200);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 7;
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 292);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonHighscores);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSubTitle2);
            this.Controls.Add(this.labelSubTitle1);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormEndGame";
            this.Text = "FormEndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle2;
        private System.Windows.Forms.Label labelSubTitle1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonHighscores;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelError;
    }
}