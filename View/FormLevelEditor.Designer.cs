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
            this.panelRocketLauncher = new System.Windows.Forms.Panel();
            this.panelSandbag = new System.Windows.Forms.Panel();
            this.panelFinish = new System.Windows.Forms.Panel();
            this.panelMud = new System.Windows.Forms.Panel();
            this.panelMine = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVisable)).BeginInit();
            this.panelToolBox.SuspendLayout();
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
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            // panelRocketLauncher
            // 
            this.panelRocketLauncher.BackgroundImage = global::WarGame.Properties.Resources.missilelauncher;
            this.panelRocketLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRocketLauncher.Location = new System.Drawing.Point(81, 154);
            this.panelRocketLauncher.Name = "panelRocketLauncher";
            this.panelRocketLauncher.Size = new System.Drawing.Size(63, 63);
            this.panelRocketLauncher.TabIndex = 4;
            this.panelRocketLauncher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RocketLauncher_MouseDown);
            // 
            // panelSandbag
            // 
            this.panelSandbag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelSandbag.BackgroundImage = global::WarGame.Properties.Resources.sandbag;
            this.panelSandbag.Location = new System.Drawing.Point(8, 154);
            this.panelSandbag.Name = "panelSandbag";
            this.panelSandbag.Size = new System.Drawing.Size(63, 63);
            this.panelSandbag.TabIndex = 4;
            this.panelSandbag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sandbag_MouseDown);
            // 
            // panelFinish
            // 
            this.panelFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelFinish.BackgroundImage = global::WarGame.Properties.Resources.finish;
            this.panelFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFinish.Location = new System.Drawing.Point(81, 85);
            this.panelFinish.Name = "panelFinish";
            this.panelFinish.Size = new System.Drawing.Size(63, 63);
            this.panelFinish.TabIndex = 4;
            this.panelFinish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Finish_MouseDown);
            // 
            // panelMud
            // 
            this.panelMud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMud.BackgroundImage = global::WarGame.Properties.Resources.mud;
            this.panelMud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMud.Location = new System.Drawing.Point(8, 85);
            this.panelMud.Name = "panelMud";
            this.panelMud.Size = new System.Drawing.Size(63, 63);
            this.panelMud.TabIndex = 3;
            this.panelMud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mud_MouseDown);
            // 
            // panelMine
            // 
            this.panelMine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMine.BackgroundImage = global::WarGame.Properties.Resources.mine;
            this.panelMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMine.Location = new System.Drawing.Point(8, 16);
            this.panelMine.Name = "panelMine";
            this.panelMine.Size = new System.Drawing.Size(63, 63);
            this.panelMine.TabIndex = 3;
            this.panelMine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mine_MouseDown);
            // 
            // panelTree
            // 
            this.panelTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTree.BackgroundImage = global::WarGame.Properties.Resources.tree;
            this.panelTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTree.Location = new System.Drawing.Point(81, 16);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(63, 63);
            this.panelTree.TabIndex = 2;
            this.panelTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tree_MouseDown);
            // 
            // FormLevelEditor
            // 
            this.AllowDrop = true;
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
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormLevelEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormLevelEditor_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLevelEditor_Paint);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVisable)).EndInit();
            this.panelToolBox.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelSandbag;
        private System.Windows.Forms.Panel panelFinish;
        private System.Windows.Forms.Panel panelMud;
        private System.Windows.Forms.Panel panelMine;
    }
}