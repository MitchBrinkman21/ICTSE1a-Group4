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
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.timerImportState = new System.Windows.Forms.Timer(this.components);
            this.buttonHighscores = new System.Windows.Forms.Button();
            this.checkboxDevMode = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonImportLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(280, 346);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Quit";
            this.buttonExit.UseMnemonic = false;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonHelp.Location = new System.Drawing.Point(280, 283);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(135, 40);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseMnemonic = false;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // timerImportState
            // 
            this.timerImportState.Interval = 600;
            this.timerImportState.Tick += new System.EventHandler(this.timerImportState_Tick);
            // 
            // buttonHighscores
            // 
            this.buttonHighscores.BackColor = System.Drawing.Color.Transparent;
            this.buttonHighscores.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonHighscores.Location = new System.Drawing.Point(280, 220);
            this.buttonHighscores.Name = "buttonHighscores";
            this.buttonHighscores.Size = new System.Drawing.Size(135, 40);
            this.buttonHighscores.TabIndex = 4;
            this.buttonHighscores.Text = "Highscores";
            this.buttonHighscores.UseVisualStyleBackColor = false;
            // 
            // checkboxDevMode
            // 
            this.checkboxDevMode.AutoSize = true;
            this.checkboxDevMode.BackColor = System.Drawing.Color.Transparent;
            this.checkboxDevMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxDevMode.Location = new System.Drawing.Point(13, 402);
            this.checkboxDevMode.Name = "checkboxDevMode";
            this.checkboxDevMode.Size = new System.Drawing.Size(106, 16);
            this.checkboxDevMode.TabIndex = 5;
            this.checkboxDevMode.Text = "Developer mode";
            this.checkboxDevMode.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(280, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonImportLevel
            // 
            this.buttonImportLevel.BackColor = System.Drawing.Color.Transparent;
            this.buttonImportLevel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonImportLevel.Location = new System.Drawing.Point(280, 157);
            this.buttonImportLevel.Name = "buttonImportLevel";
            this.buttonImportLevel.Size = new System.Drawing.Size(135, 40);
            this.buttonImportLevel.TabIndex = 3;
            this.buttonImportLevel.Text = "Import Level";
            this.buttonImportLevel.UseVisualStyleBackColor = false;
            this.buttonImportLevel.Click += new System.EventHandler(this.buttonImportLevel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::WarGame.Properties.Resources.Mainbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 431);
            this.Controls.Add(this.checkboxDevMode);
            this.Controls.Add(this.buttonHighscores);
            this.Controls.Add(buttonImportLevel);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarGame";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Button buttonStart;
        System.Windows.Forms.Button buttonImportLevel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Timer timerImportState;
        private System.Windows.Forms.Button buttonHighscores;
        private System.Windows.Forms.CheckBox checkboxDevMode;
    }
}