namespace WarGame.View
{
    partial class FormGameField
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStartPause = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageHealthKit3 = new System.Windows.Forms.PictureBox();
            this.imageHealthKit2 = new System.Windows.Forms.PictureBox();
            this.imageHealthKit1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStartPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonStartPause);
            this.panelMenu.Controls.Add(this.buttonStop);
            this.panelMenu.Controls.Add(this.buttonReset);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.imageHealthKit3);
            this.panelMenu.Controls.Add(this.imageHealthKit2);
            this.panelMenu.Controls.Add(this.imageHealthKit1);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1803, 33);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartPause.Image = global::WarGame.Properties.Resources.pause1;
            this.buttonStartPause.Location = new System.Drawing.Point(1639, 0);
            this.buttonStartPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(44, 33);
            this.buttonStartPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonStartPause.TabIndex = 9;
            this.buttonStartPause.TabStop = false;
            this.buttonStartPause.Tag = "pause";
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.Image = global::WarGame.Properties.Resources.stop1;
            this.buttonStop.Location = new System.Drawing.Point(1691, 0);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(44, 33);
            this.buttonStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonStop.TabIndex = 8;
            this.buttonStop.TabStop = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.Image = global::WarGame.Properties.Resources.reset1;
            this.buttonReset.Location = new System.Drawing.Point(1743, 0);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(44, 33);
            this.buttonReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonReset.TabIndex = 7;
            this.buttonReset.TabStop = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(852, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "0.0\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageHealthKit3
            // 
            this.imageHealthKit3.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit3.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit3.Location = new System.Drawing.Point(108, 0);
            this.imageHealthKit3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageHealthKit3.Name = "imageHealthKit3";
            this.imageHealthKit3.Size = new System.Drawing.Size(37, 28);
            this.imageHealthKit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHealthKit3.TabIndex = 3;
            this.imageHealthKit3.TabStop = false;
            this.imageHealthKit3.Tag = "3";
            // 
            // imageHealthKit2
            // 
            this.imageHealthKit2.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit2.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit2.Location = new System.Drawing.Point(63, 0);
            this.imageHealthKit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageHealthKit2.Name = "imageHealthKit2";
            this.imageHealthKit2.Size = new System.Drawing.Size(37, 28);
            this.imageHealthKit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHealthKit2.TabIndex = 2;
            this.imageHealthKit2.TabStop = false;
            this.imageHealthKit2.Tag = "2";
            // 
            // imageHealthKit1
            // 
            this.imageHealthKit1.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit1.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit1.Location = new System.Drawing.Point(17, 0);
            this.imageHealthKit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageHealthKit1.Name = "imageHealthKit1";
            this.imageHealthKit1.Size = new System.Drawing.Size(37, 28);
            this.imageHealthKit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHealthKit1.TabIndex = 1;
            this.imageHealthKit1.TabStop = false;
            this.imageHealthKit1.Tag = "1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarGame.Properties.Resources.backgrounddrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1801, 897);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormGameField";
            this.Text = "GameField";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGameField_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameField_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGameField_KeyUp);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStartPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHealthKit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox imageHealthKit1;
        private System.Windows.Forms.PictureBox imageHealthKit2;
        private System.Windows.Forms.PictureBox imageHealthKit3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox buttonStartPause;
        private System.Windows.Forms.PictureBox buttonStop;
        private System.Windows.Forms.PictureBox buttonReset;



    }
}