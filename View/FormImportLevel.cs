﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WarGame.View
{
    public partial class FormImportLevel : Form
    {
        public XmlDocument doc;
        FileInfo[] files;
        bool buttonClicked = false;
        string filenameLevelPicker;
        string selectedfile;
        Button selected = new Button();


        public FormImportLevel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            files = readLevelFolder("C:/Wargame/levels");
            addButtonsToLevelPicker(files);
            selectedfile = null;

        }

        private void buttonBrowseXML_Click(object sender, EventArgs e)
        {
            addFile();
        }
        public FileInfo[] readLevelFolder(string folder)
        {
            DirectoryInfo di = new DirectoryInfo(folder);
            FileInfo[] files = di.GetFiles("*.xml");
            return files;
        }
        public void addButtonsToLevelPicker(FileInfo[] files)
        {            
            panelLevelPicker.Controls.Clear();
            int y = 0;
            foreach (FileInfo file in files)
            {
                Button button = new Button();               
                button.Size = new Size(362, 30);
                button.Location = new Point(0, y);
                button.Text = file.ToString().Remove(file.ToString().Length - 4);
                button.Tag = file.FullName;
                button.Click += new System.EventHandler(levelPicked);
                button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.HighlightText;
                panelLevelPicker.Controls.Add(button);
                y += 30;
                if (selectedfile == file.ToString())
                {
                    selected.BackColor = System.Drawing.Color.Black;
                    selected = button;
                    selected.BackColor = System.Drawing.Color.Red;
                    textBoxXMLFile.Text = button.Text;
                    filenameLevelPicker = button.Tag.ToString();
                    buttonClicked = true;
                }
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 
        private void levelPicked(Object sender, EventArgs e)
        {
            Button b = sender as Button;
            filenameLevelPicker = b.Tag.ToString();
            textBoxXMLFile.Text = b.Text;
            ForeColor = System.Drawing.SystemColors.HighlightText;
            selected.BackColor = System.Drawing.Color.Black;
            selected = b;
            selectedfile = b.Text;
            selected.BackColor = System.Drawing.Color.Red;
            buttonClicked = true;
        }

        void addFile()
        {
            OpenFileDialog BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "XML Files (*.xml)|*.xml";
            BrowseFile.FilterIndex = 0;
            BrowseFile.DefaultExt = "xml";
            if (BrowseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    selectedfile = System.IO.Path.GetFileName(BrowseFile.FileName);
                    System.IO.File.Copy(BrowseFile.FileName, "C:/Wargame/levels/" + System.IO.Path.GetFileName(BrowseFile.FileName));
                    textBoxXMLFile.Text = System.IO.Path.GetFileName(BrowseFile.FileName);
                }catch(IOException e){
                    MessageBox.Show("This file already exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
            files = readLevelFolder("C:/WarGame/levels");
            addButtonsToLevelPicker(files);
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                if (buttonClicked == true)
                {
                    try
                    {
                        doc = new XmlDocument();
                        doc.Load(filenameLevelPicker);
                    }
                    catch (Exception ex)
                    {
                        doc = null;
                        MessageBox.Show("File not found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
