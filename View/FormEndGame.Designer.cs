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
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(139, 337);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(331, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Reached base!";
            // 
            // labelSubTitle2
            // 
            this.labelSubTitle2.AutoSize = true;
            this.labelSubTitle2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle2.Location = new System.Drawing.Point(18, 435);
            this.labelSubTitle2.Name = "labelSubTitle2";
            this.labelSubTitle2.Size = new System.Drawing.Size(127, 24);
            this.labelSubTitle2.TabIndex = 2;
            this.labelSubTitle2.Text = "Your name:";
            // 
            // labelSubTitle1
            // 
            this.labelSubTitle1.AutoSize = true;
            this.labelSubTitle1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle1.Location = new System.Drawing.Point(18, 403);
            this.labelSubTitle1.Name = "labelSubTitle1";
            this.labelSubTitle1.Size = new System.Drawing.Size(122, 24);
            this.labelSubTitle1.TabIndex = 1;
            this.labelSubTitle1.Text = "Your time:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(165, 403);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 24);
            this.labelTime.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 439);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(513, 426);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 43);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WarGame.Properties.Resources.star_sprangled_banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(619, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSubTitle2);
            this.Controls.Add(this.labelSubTitle1);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormEndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End of the operation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle2;
        private System.Windows.Forms.Label labelSubTitle1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}