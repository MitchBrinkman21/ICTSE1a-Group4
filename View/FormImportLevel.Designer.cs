namespace WarGame.View
{
    partial class FormImportLevel
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
            this.Button = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxXMLFile = new System.Windows.Forms.TextBox();
            this.labelImportHelp = new System.Windows.Forms.Label();
            this.buttonBrowseXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button.Location = new System.Drawing.Point(12, 129);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(178, 65);
            this.Button.TabIndex = 9;
            this.Button.Text = "Cancel";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(582, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(178, 65);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "OK";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // textBoxXMLFile
            // 
            this.textBoxXMLFile.Location = new System.Drawing.Point(25, 65);
            this.textBoxXMLFile.Name = "textBoxXMLFile";
            this.textBoxXMLFile.Size = new System.Drawing.Size(593, 31);
            this.textBoxXMLFile.TabIndex = 7;
            // 
            // labelImportHelp
            // 
            this.labelImportHelp.AutoSize = true;
            this.labelImportHelp.Location = new System.Drawing.Point(20, 18);
            this.labelImportHelp.Name = "labelImportHelp";
            this.labelImportHelp.Size = new System.Drawing.Size(222, 25);
            this.labelImportHelp.TabIndex = 6;
            this.labelImportHelp.Text = "Select a level file(xml)";
            // 
            // buttonBrowseXML
            // 
            this.buttonBrowseXML.Location = new System.Drawing.Point(624, 65);
            this.buttonBrowseXML.Name = "buttonBrowseXML";
            this.buttonBrowseXML.Size = new System.Drawing.Size(103, 38);
            this.buttonBrowseXML.TabIndex = 5;
            this.buttonBrowseXML.Text = "Browse";
            this.buttonBrowseXML.UseVisualStyleBackColor = true;
            this.buttonBrowseXML.Click += new System.EventHandler(this.buttonBrowseXML_Click);
            // 
            // FormImportLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 206);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxXMLFile);
            this.Controls.Add(this.labelImportHelp);
            this.Controls.Add(this.buttonBrowseXML);
            this.Name = "FormImportLevel";
            this.Text = "Import level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxXMLFile;
        private System.Windows.Forms.Label labelImportHelp;
        private System.Windows.Forms.Button buttonBrowseXML;
    }
}