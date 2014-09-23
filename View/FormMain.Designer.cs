namespace WarGame.View
{
    partial class FormMain
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
            System.Windows.Forms.Button buttonStart;
            System.Windows.Forms.Button buttonImportLevel;
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            buttonStart = new System.Windows.Forms.Button();
            buttonImportLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonStart.Location = new System.Drawing.Point(49, 41);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(653, 119);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start Game";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(49, 494);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(653, 119);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Quit";
            this.buttonExit.UseMnemonic = false;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(49, 338);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(653, 119);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseMnemonic = false;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonImportLevel
            // 
            buttonImportLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            buttonImportLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonImportLevel.Location = new System.Drawing.Point(49, 189);
            buttonImportLevel.Name = "buttonImportLevel";
            buttonImportLevel.Size = new System.Drawing.Size(653, 119);
            buttonImportLevel.TabIndex = 3;
            buttonImportLevel.Text = "Import Level";
            buttonImportLevel.UseVisualStyleBackColor = true;
            buttonImportLevel.Click += new System.EventHandler(this.buttonImportLevel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 750);
            this.Controls.Add(buttonImportLevel);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.Text = "WarGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
    }
}