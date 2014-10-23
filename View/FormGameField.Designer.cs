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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameField));
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.buttonStartPause);
            this.panelMenu.Controls.Add(this.buttonStop);
            this.panelMenu.Controls.Add(this.buttonReset);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.imageHealthKit3);
            this.panelMenu.Controls.Add(this.imageHealthKit2);
            this.panelMenu.Controls.Add(this.imageHealthKit1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1367, 30);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartPause.Image = global::WarGame.Properties.Resources.pause;
            this.buttonStartPause.Location = new System.Drawing.Point(1229, 0);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(33, 27);
            this.buttonStartPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonStartPause.TabIndex = 9;
            this.buttonStartPause.TabStop = false;
            this.buttonStartPause.Tag = "pause";
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.Image = global::WarGame.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(1268, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(33, 27);
            this.buttonStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonStop.TabIndex = 8;
            this.buttonStop.TabStop = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.Image = global::WarGame.Properties.Resources.reset;
            this.buttonReset.Location = new System.Drawing.Point(1307, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(33, 27);
            this.buttonReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonReset.TabIndex = 7;
            this.buttonReset.TabStop = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(671, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "0.0\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageHealthKit3
            // 
            this.imageHealthKit3.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit3.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit3.Location = new System.Drawing.Point(81, 0);
            this.imageHealthKit3.Name = "imageHealthKit3";
            this.imageHealthKit3.Size = new System.Drawing.Size(28, 23);
            this.imageHealthKit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHealthKit3.TabIndex = 3;
            this.imageHealthKit3.TabStop = false;
            this.imageHealthKit3.Tag = "3";
            // 
            // imageHealthKit2
            // 
            this.imageHealthKit2.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit2.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit2.Location = new System.Drawing.Point(47, 0);
            this.imageHealthKit2.Name = "imageHealthKit2";
            this.imageHealthKit2.Size = new System.Drawing.Size(28, 23);
            this.imageHealthKit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHealthKit2.TabIndex = 2;
            this.imageHealthKit2.TabStop = false;
            this.imageHealthKit2.Tag = "2";
            // 
            // imageHealthKit1
            // 
            this.imageHealthKit1.BackColor = System.Drawing.Color.Transparent;
            this.imageHealthKit1.Image = global::WarGame.Properties.Resources.first_aid_kit;
            this.imageHealthKit1.Location = new System.Drawing.Point(13, 0);
            this.imageHealthKit1.Name = "imageHealthKit1";
            this.imageHealthKit1.Size = new System.Drawing.Size(28, 23);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WarGame.Properties.Resources.backgrounddrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGameField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarGame";
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