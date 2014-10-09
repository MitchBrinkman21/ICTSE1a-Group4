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
            this.panelLevelPicker = new System.Windows.Forms.Panel();
            this.scrollbarLevelPicker = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button.Location = new System.Drawing.Point(13, 363);
            this.Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(89, 34);
            this.Button.TabIndex = 9;
            this.Button.Text = "Cancel";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(308, 363);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 34);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "OK";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxXMLFile
            // 
            this.textBoxXMLFile.Location = new System.Drawing.Point(13, 318);
            this.textBoxXMLFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxXMLFile.Name = "textBoxXMLFile";
            this.textBoxXMLFile.Size = new System.Drawing.Size(298, 20);
            this.textBoxXMLFile.TabIndex = 7;
            // 
            // labelImportHelp
            // 
            this.labelImportHelp.AutoSize = true;
            this.labelImportHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelImportHelp.Location = new System.Drawing.Point(13, 292);
            this.labelImportHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImportHelp.Name = "labelImportHelp";
            this.labelImportHelp.Size = new System.Drawing.Size(54, 13);
            this.labelImportHelp.TabIndex = 6;
            this.labelImportHelp.Text = "Add level:";
            // 
            // buttonBrowseXML
            // 
            this.buttonBrowseXML.BackColor = System.Drawing.Color.Black;
            this.buttonBrowseXML.FlatAppearance.BorderSize = 0;
            this.buttonBrowseXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBrowseXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBrowseXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseXML.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBrowseXML.Location = new System.Drawing.Point(314, 312);
            this.buttonBrowseXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrowseXML.Name = "buttonBrowseXML";
            this.buttonBrowseXML.Size = new System.Drawing.Size(52, 29);
            this.buttonBrowseXML.TabIndex = 5;
            this.buttonBrowseXML.Text = "Browse";
            this.buttonBrowseXML.UseVisualStyleBackColor = false;
            this.buttonBrowseXML.Click += new System.EventHandler(this.buttonBrowseXML_Click);
            // 
            // panelLevelPicker
            // 
            this.panelLevelPicker.Location = new System.Drawing.Point(13, 13);
            this.panelLevelPicker.Name = "panelLevelPicker";
            this.panelLevelPicker.Size = new System.Drawing.Size(362, 268);
            this.panelLevelPicker.TabIndex = 10;
            // 
            // scrollbarLevelPicker
            // 
            this.scrollbarLevelPicker.Location = new System.Drawing.Point(385, 13);
            this.scrollbarLevelPicker.Name = "scrollbarLevelPicker";
            this.scrollbarLevelPicker.Size = new System.Drawing.Size(16, 268);
            this.scrollbarLevelPicker.TabIndex = 11;
            this.scrollbarLevelPicker.Visible = false;
            // 
            // FormImportLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(407, 405);
            this.Controls.Add(this.scrollbarLevelPicker);
            this.Controls.Add(this.panelLevelPicker);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxXMLFile);
            this.Controls.Add(this.labelImportHelp);
            this.Controls.Add(this.buttonBrowseXML);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Panel panelLevelPicker;
        private System.Windows.Forms.VScrollBar scrollbarLevelPicker;
    }
}