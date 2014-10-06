namespace WarGame.View
{
    partial class FormLevelEditor
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            this.buttonVisable = new System.Windows.Forms.PictureBox();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.pictureBoxMine = new System.Windows.Forms.PictureBox();
            this.panelMine = new System.Windows.Forms.Panel();
            this.pictureBoxMud = new System.Windows.Forms.PictureBox();
            this.panelMud = new System.Windows.Forms.Panel();
            this.panelFinish = new System.Windows.Forms.Panel();
            this.pictureBoxFinish = new System.Windows.Forms.PictureBox();
            this.panelSandbag = new System.Windows.Forms.Panel();
            this.pictureBoxSandbag = new System.Windows.Forms.PictureBox();
            this.panelRocketLauncher = new System.Windows.Forms.Panel();
            this.pictureBoxRocketLauncher = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVisable)).BeginInit();
            this.panelToolBox.SuspendLayout();
            this.panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).BeginInit();
            this.panelMine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMud)).BeginInit();
            this.panelMud.SuspendLayout();
            this.panelFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).BeginInit();
            this.panelSandbag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSandbag)).BeginInit();
            this.panelRocketLauncher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocketLauncher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMenu.Controls.Add(this.buttonLoad);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonVisable);
            this.panelMenu.Location = new System.Drawing.Point(1217, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(148, 32);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(21, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(25, 25);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(62, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(25, 25);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.TabStop = false;
            // 
            // buttonVisable
            // 
            this.buttonVisable.Location = new System.Drawing.Point(105, 4);
            this.buttonVisable.Name = "buttonVisable";
            this.buttonVisable.Size = new System.Drawing.Size(25, 25);
            this.buttonVisable.TabIndex = 1;
            this.buttonVisable.TabStop = false;
            this.buttonVisable.Click += new System.EventHandler(this.buttonVisable_Click);
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelToolBox.Controls.Add(this.panelRocketLauncher);
            this.panelToolBox.Controls.Add(this.panelSandbag);
            this.panelToolBox.Controls.Add(this.panelFinish);
            this.panelToolBox.Controls.Add(this.panelMud);
            this.panelToolBox.Controls.Add(this.panelMine);
            this.panelToolBox.Controls.Add(this.panelTree);
            this.panelToolBox.Location = new System.Drawing.Point(1217, 32);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(148, 234);
            this.panelToolBox.TabIndex = 0;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.pictureBoxTree);
            this.panelTree.Location = new System.Drawing.Point(81, 16);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(63, 63);
            this.panelTree.TabIndex = 2;
            this.panelTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mine_MouseDown);
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTree.Image = global::WarGame.Properties.Resources.tree;
            this.pictureBoxTree.Location = new System.Drawing.Point(6, 7);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // pictureBoxMine
            // 
            this.pictureBoxMine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMine.Image = global::WarGame.Properties.Resources.mine;
            this.pictureBoxMine.Location = new System.Drawing.Point(16, 17);
            this.pictureBoxMine.Name = "pictureBoxMine";
            this.pictureBoxMine.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMine.TabIndex = 0;
            this.pictureBoxMine.TabStop = false;
            // 
            // panelMine
            // 
            this.panelMine.Controls.Add(this.pictureBoxMine);
            this.panelMine.Location = new System.Drawing.Point(8, 16);
            this.panelMine.Name = "panelMine";
            this.panelMine.Size = new System.Drawing.Size(63, 63);
            this.panelMine.TabIndex = 3;
            // 
            // pictureBoxMud
            // 
            this.pictureBoxMud.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMud.Image = global::WarGame.Properties.Resources.mud;
            this.pictureBoxMud.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxMud.Name = "pictureBoxMud";
            this.pictureBoxMud.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMud.TabIndex = 0;
            this.pictureBoxMud.TabStop = false;
            // 
            // panelMud
            // 
            this.panelMud.Controls.Add(this.pictureBoxMud);
            this.panelMud.Location = new System.Drawing.Point(8, 85);
            this.panelMud.Name = "panelMud";
            this.panelMud.Size = new System.Drawing.Size(63, 63);
            this.panelMud.TabIndex = 3;
            // 
            // panelFinish
            // 
            this.panelFinish.Controls.Add(this.pictureBoxFinish);
            this.panelFinish.Location = new System.Drawing.Point(81, 85);
            this.panelFinish.Name = "panelFinish";
            this.panelFinish.Size = new System.Drawing.Size(63, 63);
            this.panelFinish.TabIndex = 4;
            // 
            // pictureBoxFinish
            // 
            this.pictureBoxFinish.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFinish.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxFinish.Name = "pictureBoxFinish";
            this.pictureBoxFinish.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFinish.TabIndex = 0;
            this.pictureBoxFinish.TabStop = false;
            // 
            // panelSandbag
            // 
            this.panelSandbag.Controls.Add(this.pictureBoxSandbag);
            this.panelSandbag.Location = new System.Drawing.Point(8, 154);
            this.panelSandbag.Name = "panelSandbag";
            this.panelSandbag.Size = new System.Drawing.Size(63, 63);
            this.panelSandbag.TabIndex = 4;
            // 
            // pictureBoxSandbag
            // 
            this.pictureBoxSandbag.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSandbag.Image = global::WarGame.Properties.Resources.sandbag;
            this.pictureBoxSandbag.Location = new System.Drawing.Point(14, 19);
            this.pictureBoxSandbag.Name = "pictureBoxSandbag";
            this.pictureBoxSandbag.Size = new System.Drawing.Size(35, 25);
            this.pictureBoxSandbag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSandbag.TabIndex = 0;
            this.pictureBoxSandbag.TabStop = false;
            // 
            // panelRocketLauncher
            // 
            this.panelRocketLauncher.Controls.Add(this.pictureBoxRocketLauncher);
            this.panelRocketLauncher.Location = new System.Drawing.Point(81, 154);
            this.panelRocketLauncher.Name = "panelRocketLauncher";
            this.panelRocketLauncher.Size = new System.Drawing.Size(63, 63);
            this.panelRocketLauncher.TabIndex = 4;
            // 
            // pictureBoxRocketLauncher
            // 
            this.pictureBoxRocketLauncher.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRocketLauncher.Image = global::WarGame.Properties.Resources.missilelauncher;
            this.pictureBoxRocketLauncher.Location = new System.Drawing.Point(3, 1);
            this.pictureBoxRocketLauncher.Name = "pictureBoxRocketLauncher";
            this.pictureBoxRocketLauncher.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxRocketLauncher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRocketLauncher.TabIndex = 0;
            this.pictureBoxRocketLauncher.TabStop = false;
            // 
            // FormLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarGame.Properties.Resources.backgrounddrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Name = "FormLevelEditor";
            this.Text = "FormLevelEditor";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVisable)).EndInit();
            this.panelToolBox.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).EndInit();
            this.panelMine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMud)).EndInit();
            this.panelMud.ResumeLayout(false);
            this.panelFinish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).EndInit();
            this.panelSandbag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSandbag)).EndInit();
            this.panelRocketLauncher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocketLauncher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.PictureBox buttonLoad;
        private System.Windows.Forms.PictureBox buttonSave;
        private System.Windows.Forms.PictureBox buttonVisable;
        private System.Windows.Forms.Panel panelRocketLauncher;
        private System.Windows.Forms.PictureBox pictureBoxRocketLauncher;
        private System.Windows.Forms.Panel panelSandbag;
        private System.Windows.Forms.PictureBox pictureBoxSandbag;
        private System.Windows.Forms.Panel panelFinish;
        private System.Windows.Forms.PictureBox pictureBoxFinish;
        private System.Windows.Forms.Panel panelMud;
        private System.Windows.Forms.PictureBox pictureBoxMud;
        private System.Windows.Forms.Panel panelMine;
        private System.Windows.Forms.PictureBox pictureBoxMine;
        private System.Windows.Forms.PictureBox pictureBoxTree;
    }
}