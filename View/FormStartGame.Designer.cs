namespace WarGame.View
{
    partial class FormStartGame
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
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowseXML = new System.Windows.Forms.Button();
            this.labelImportHelp = new System.Windows.Forms.Label();
            this.textBoxXMLFile = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.Tag = ".XML";
            // 
            // buttonBrowseXML
            // 
            this.buttonBrowseXML.Location = new System.Drawing.Point(616, 56);
            this.buttonBrowseXML.Name = "buttonBrowseXML";
            this.buttonBrowseXML.Size = new System.Drawing.Size(103, 38);
            this.buttonBrowseXML.TabIndex = 0;
            this.buttonBrowseXML.Text = "Browse";
            this.buttonBrowseXML.UseVisualStyleBackColor = true;
            this.buttonBrowseXML.Click += new System.EventHandler(this.buttonBrowseXML_Click);
            // 
            // labelImportHelp
            // 
            this.labelImportHelp.AutoSize = true;
            this.labelImportHelp.Location = new System.Drawing.Point(12, 9);
            this.labelImportHelp.Name = "labelImportHelp";
            this.labelImportHelp.Size = new System.Drawing.Size(222, 25);
            this.labelImportHelp.TabIndex = 1;
            this.labelImportHelp.Text = "Select a level file(xml)";
            // 
            // textBoxXMLFile
            // 
            this.textBoxXMLFile.Location = new System.Drawing.Point(17, 56);
            this.textBoxXMLFile.Name = "textBoxXMLFile";
            this.textBoxXMLFile.Size = new System.Drawing.Size(593, 31);
            this.textBoxXMLFile.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(572, 304);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(178, 65);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 304);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(178, 65);
            this.Button.TabIndex = 4;
            this.Button.Text = "Cancel";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // FormStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 381);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxXMLFile);
            this.Controls.Add(this.labelImportHelp);
            this.Controls.Add(this.buttonBrowseXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormStartGame";
            this.Text = "WarGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.Button buttonBrowseXML;
        private System.Windows.Forms.Label labelImportHelp;
        private System.Windows.Forms.TextBox textBoxXMLFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button Button;
    }
}

