﻿namespace WarGame.View
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
            this.SuspendLayout();
            // 
            // labelGameOverMessage
            // 
            this.labelGameOverMessage.AutoSize = true;
            this.labelGameOverMessage.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOverMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameOverMessage.Location = new System.Drawing.Point(67, 34);
            this.labelGameOverMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameOverMessage.Name = "labelGameOverMessage";
            this.labelGameOverMessage.Size = new System.Drawing.Size(227, 29);
            this.labelGameOverMessage.TabIndex = 0;
            this.labelGameOverMessage.Text = "Killed in action!";
            // 
            // buttonRetry
            // 
            this.buttonRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetry.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRetry.Location = new System.Drawing.Point(269, 267);
            this.buttonRetry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(100, 39);
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
            this.buttonToMenu.Location = new System.Drawing.Point(17, 267);
            this.buttonToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToMenu.Name = "buttonToMenu";
            this.buttonToMenu.Size = new System.Drawing.Size(100, 39);
            this.buttonToMenu.TabIndex = 2;
            this.buttonToMenu.Text = "Exit";
            this.buttonToMenu.UseVisualStyleBackColor = true;
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.buttonToMenu);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.labelGameOverMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGameOver";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOverMessage;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Button buttonToMenu;
    }
}