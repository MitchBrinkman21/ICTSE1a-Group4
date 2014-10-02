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
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelGameVersion = new System.Windows.Forms.Label();
            this.buttonLevelEditor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonImportLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(280, 345);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Quit";
            this.buttonExit.UseMnemonic = false;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp.Location = new System.Drawing.Point(280, 231);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(160, 40);
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
            this.buttonHighscores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonHighscores.FlatAppearance.BorderSize = 0;
            this.buttonHighscores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHighscores.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.buttonHighscores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHighscores.Location = new System.Drawing.Point(280, 174);
            this.buttonHighscores.Name = "buttonHighscores";
            this.buttonHighscores.Size = new System.Drawing.Size(160, 40);
            this.buttonHighscores.TabIndex = 4;
            this.buttonHighscores.Text = "Highscores";
            this.buttonHighscores.UseVisualStyleBackColor = false;
            this.buttonHighscores.Click += new System.EventHandler(this.buttonHighscores_Click);
            // 
            // checkboxDevMode
            // 
            this.checkboxDevMode.AutoSize = true;
            this.checkboxDevMode.BackColor = System.Drawing.Color.Transparent;
            this.checkboxDevMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxDevMode.Location = new System.Drawing.Point(13, 402);
            this.checkboxDevMode.Name = "checkboxDevMode";
            this.checkboxDevMode.Size = new System.Drawing.Size(134, 19);
            this.checkboxDevMode.TabIndex = 5;
            this.checkboxDevMode.Text = "Developer mode";
            this.checkboxDevMode.UseVisualStyleBackColor = false;
            this.checkboxDevMode.CheckStateChanged += new System.EventHandler(this.checkboxDevMode_CheckStateChanged);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.BackColor = System.Drawing.Color.Transparent;
            this.labelGameName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameName.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameName.Location = new System.Drawing.Point(529, 9);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(198, 46);
            this.labelGameName.TabIndex = 6;
            this.labelGameName.Text = "WarGame";
            // 
            // labelGameVersion
            // 
            this.labelGameVersion.AutoSize = true;
            this.labelGameVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelGameVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.labelGameVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameVersion.Location = new System.Drawing.Point(606, 406);
            this.labelGameVersion.Name = "labelGameVersion";
            this.labelGameVersion.Size = new System.Drawing.Size(92, 15);
            this.labelGameVersion.TabIndex = 7;
            this.labelGameVersion.Text = "Ver. 1.0.1-RC";
            // 
            // buttonLevelEditor
            // 
            this.buttonLevelEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonLevelEditor.FlatAppearance.BorderSize = 0;
            this.buttonLevelEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonLevelEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelEditor.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.buttonLevelEditor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLevelEditor.Location = new System.Drawing.Point(280, 288);
            this.buttonLevelEditor.Name = "buttonLevelEditor";
            this.buttonLevelEditor.Size = new System.Drawing.Size(160, 40);
            this.buttonLevelEditor.TabIndex = 8;
            this.buttonLevelEditor.Text = "Level Editor";
            this.buttonLevelEditor.UseMnemonic = false;
            this.buttonLevelEditor.UseVisualStyleBackColor = false;
            this.buttonLevelEditor.Click += new System.EventHandler(this.buttonLevelEditor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStart.Font = new System.Drawing.Font("Stencil", 14.25F);
            buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonStart.Location = new System.Drawing.Point(280, 60);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(160, 40);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start Game";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonImportLevel
            // 
            buttonImportLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            buttonImportLevel.FlatAppearance.BorderSize = 0;
            buttonImportLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            buttonImportLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonImportLevel.Font = new System.Drawing.Font("Stencil", 14.25F);
            buttonImportLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonImportLevel.Location = new System.Drawing.Point(280, 117);
            buttonImportLevel.Name = "buttonImportLevel";
            buttonImportLevel.Size = new System.Drawing.Size(160, 40);
            buttonImportLevel.TabIndex = 3;
            buttonImportLevel.Text = "Import level";
            buttonImportLevel.UseVisualStyleBackColor = false;
            buttonImportLevel.Click += new System.EventHandler(this.buttonImportLevel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::WarGame.Properties.Resources.Mainbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 431);
            this.Controls.Add(this.buttonLevelEditor);
            this.Controls.Add(this.labelGameVersion);
            this.Controls.Add(this.labelGameName);
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
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelGameVersion;
        private System.Windows.Forms.Button buttonLevelEditor;
        private System.Windows.Forms.Timer timer1;
    }
}