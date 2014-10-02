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
            this.Rocketlauncher = new System.Windows.Forms.Panel();
            this.Finish = new System.Windows.Forms.Panel();
            this.Sandbag = new System.Windows.Forms.Panel();
            this.Mud = new System.Windows.Forms.Panel();
            this.Tree = new System.Windows.Forms.Panel();
            this.Mine = new System.Windows.Forms.Panel();
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
            this.panelToolBox.Controls.Add(this.Rocketlauncher);
            this.panelToolBox.Controls.Add(this.Finish);
            this.panelToolBox.Controls.Add(this.Sandbag);
            this.panelToolBox.Controls.Add(this.Mud);
            this.panelToolBox.Controls.Add(this.Tree);
            this.panelToolBox.Controls.Add(this.Mine);
            this.panelToolBox.Location = new System.Drawing.Point(1217, 32);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(148, 697);
            this.panelToolBox.TabIndex = 0;
            // 
            // Rocketlauncher
            // 
            this.Rocketlauncher.Location = new System.Drawing.Point(25, 584);
            this.Rocketlauncher.Name = "Rocketlauncher";
            this.Rocketlauncher.Size = new System.Drawing.Size(100, 100);
            this.Rocketlauncher.TabIndex = 3;
            this.Rocketlauncher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rocketlauncher_MouseDown);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(25, 471);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(100, 100);
            this.Finish.TabIndex = 3;
            this.Finish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Finish_MouseDown);
            // 
            // Sandbag
            // 
            this.Sandbag.Location = new System.Drawing.Point(25, 358);
            this.Sandbag.Name = "Sandbag";
            this.Sandbag.Size = new System.Drawing.Size(100, 100);
            this.Sandbag.TabIndex = 3;
            this.Sandbag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sandbag_MouseDown);
            // 
            // Mud
            // 
            this.Mud.Location = new System.Drawing.Point(25, 245);
            this.Mud.Name = "Mud";
            this.Mud.Size = new System.Drawing.Size(100, 100);
            this.Mud.TabIndex = 3;
            this.Mud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mud_MouseDown);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(25, 132);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(100, 100);
            this.Tree.TabIndex = 3;
            this.Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tree_MouseDown);
            // 
            // Mine
            // 
            this.Mine.Location = new System.Drawing.Point(25, 19);
            this.Mine.Name = "Mine";
            this.Mine.Size = new System.Drawing.Size(100, 100);
            this.Mine.TabIndex = 2;
            this.Mine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mine_MouseDown);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel Rocketlauncher;
        private System.Windows.Forms.Panel Finish;
        private System.Windows.Forms.Panel Sandbag;
        private System.Windows.Forms.Panel Mud;
        private System.Windows.Forms.Panel Tree;
        private System.Windows.Forms.Panel Mine;
        private System.Windows.Forms.PictureBox buttonLoad;
        private System.Windows.Forms.PictureBox buttonSave;
        private System.Windows.Forms.PictureBox buttonVisable;
    }
}