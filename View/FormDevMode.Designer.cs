namespace WarGame.View
{
    partial class FormDevMode
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
            this.devButtonUp = new System.Windows.Forms.Button();
            this.devButtonDown = new System.Windows.Forms.Button();
            this.devButtonRight = new System.Windows.Forms.Button();
            this.devButtonLeft = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nrHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // devButtonUp
            // 
            this.devButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButtonUp.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButtonUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devButtonUp.Location = new System.Drawing.Point(170, 389);
            this.devButtonUp.Name = "devButtonUp";
            this.devButtonUp.Size = new System.Drawing.Size(46, 43);
            this.devButtonUp.TabIndex = 1;
            this.devButtonUp.Text = "↑";
            this.devButtonUp.UseVisualStyleBackColor = true;
            this.devButtonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.devButtonUp_MouseDown);
            this.devButtonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.devButtonUp_MouseUp);
            // 
            // devButtonDown
            // 
            this.devButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButtonDown.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButtonDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devButtonDown.Location = new System.Drawing.Point(170, 438);
            this.devButtonDown.Name = "devButtonDown";
            this.devButtonDown.Size = new System.Drawing.Size(46, 43);
            this.devButtonDown.TabIndex = 2;
            this.devButtonDown.Text = "↓";
            this.devButtonDown.UseVisualStyleBackColor = true;
            this.devButtonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.devButtonDown_MouseDown);
            this.devButtonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.devButtonDown_MouseUp);
            // 
            // devButtonRight
            // 
            this.devButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButtonRight.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButtonRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devButtonRight.Location = new System.Drawing.Point(222, 438);
            this.devButtonRight.Name = "devButtonRight";
            this.devButtonRight.Size = new System.Drawing.Size(46, 43);
            this.devButtonRight.TabIndex = 3;
            this.devButtonRight.Text = "→";
            this.devButtonRight.UseVisualStyleBackColor = true;
            this.devButtonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.devButtonRight_MouseDown);
            this.devButtonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.devButtonRight_MouseUp);
            // 
            // devButtonLeft
            // 
            this.devButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButtonLeft.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButtonLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devButtonLeft.Location = new System.Drawing.Point(118, 438);
            this.devButtonLeft.Name = "devButtonLeft";
            this.devButtonLeft.Size = new System.Drawing.Size(46, 43);
            this.devButtonLeft.TabIndex = 4;
            this.devButtonLeft.Text = "←";
            this.devButtonLeft.UseVisualStyleBackColor = true;
            this.devButtonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.devButtonLeft_MouseDown);
            this.devButtonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.devButtonLeft_MouseUp);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nrHeader,
            this.objHeader,
            this.xHeader,
            this.yHeader,
            this.spdHeader});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 371);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nrHeader
            // 
            this.nrHeader.Text = "Nr.";
            this.nrHeader.Width = 58;
            // 
            // objHeader
            // 
            this.objHeader.Text = "Object";
            this.objHeader.Width = 97;
            // 
            // xHeader
            // 
            this.xHeader.Text = "X";
            // 
            // yHeader
            // 
            this.yHeader.Text = "Y";
            // 
            // spdHeader
            // 
            this.spdHeader.Text = "Speed";
            this.spdHeader.Width = 83;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimerTick);
            // 
            // FormDevMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(387, 493);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.devButtonLeft);
            this.Controls.Add(this.devButtonRight);
            this.Controls.Add(this.devButtonDown);
            this.Controls.Add(this.devButtonUp);
            this.Name = "FormDevMode";
            this.Text = "Debug window";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button devButtonUp;
        private System.Windows.Forms.Button devButtonDown;
        private System.Windows.Forms.Button devButtonRight;
        private System.Windows.Forms.Button devButtonLeft;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nrHeader;
        private System.Windows.Forms.ColumnHeader objHeader;
        private System.Windows.Forms.ColumnHeader xHeader;
        private System.Windows.Forms.ColumnHeader yHeader;
        private System.Windows.Forms.ColumnHeader spdHeader;
        private System.Windows.Forms.Timer updateTimer;
    }
}