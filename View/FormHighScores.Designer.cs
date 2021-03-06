﻿namespace WarGame.View
{
    partial class FormHighScores
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHighScores));
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.listViewHighscores = new System.Windows.Forms.ListView();
            this.columnHeaderPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevel.Location = new System.Drawing.Point(19, 24);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(42, 13);
            this.labelLevel.TabIndex = 0;
            this.labelLevel.Text = "Level:";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(62, 20);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(113, 21);
            this.comboBoxLevel.TabIndex = 1;
            this.comboBoxLevel.Text = "Select a level";
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            this.comboBoxLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHighScores_KeyDown);
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(256, 300);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(46, 30);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // listViewHighscores
            // 
            this.listViewHighscores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPlace,
            this.columnHeaderName,
            this.columnHeaderTime});
            this.listViewHighscores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewHighscores.Location = new System.Drawing.Point(22, 63);
            this.listViewHighscores.Margin = new System.Windows.Forms.Padding(2);
            this.listViewHighscores.Name = "listViewHighscores";
            this.listViewHighscores.Size = new System.Drawing.Size(270, 218);
            this.listViewHighscores.TabIndex = 4;
            this.listViewHighscores.UseCompatibleStateImageBehavior = false;
            this.listViewHighscores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPlace
            // 
            this.columnHeaderPlace.Text = "Place";
            this.columnHeaderPlace.Width = 59;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 107;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 100;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::WarGame.Properties.Resources.recycleBinSmall;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Location = new System.Drawing.Point(186, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(19, 27);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(313, 341);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listViewHighscores);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.labelLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.FormHighScores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHighScores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ListView listViewHighscores;
        private System.Windows.Forms.ColumnHeader columnHeaderPlace;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.PictureBox buttonDelete;
    }
}