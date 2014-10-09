using System;
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

        public FormImportLevel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            files = readLevelFolder("C:/Wargame/levels");
            addButtonsToLevelPicker(files);
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
            int y = 0;
            foreach (FileInfo file in files)
            {
                Button button = new Button();
                button.Size = new Size(362, 30);
                button.Location = new Point(0, y);
                button.Text = file.ToString();
                button.Tag = file.FullName;
                button.Click += new System.EventHandler(levelPicked);
                button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.HighlightText;
                panelLevelPicker.Controls.Add(button);
                y += 30;
                if (y >= 360)
                {
                    ScrollBar vScrollBar1 = new VScrollBar();
                    vScrollBar1.Dock = DockStyle.Right;
                    vScrollBar1.Scroll += (sender, e) => { panelLevelPicker.VerticalScroll.Value = vScrollBar1.Value; };
                    panelLevelPicker.Controls.Add(vScrollBar1);
                }
            }
        }
        private void levelPicked(Object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBoxXMLFile.Text = b.Tag.ToString();
            ForeColor = System.Drawing.SystemColors.HighlightText;
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
                System.IO.File.Copy(BrowseFile.FileName, "C:/Wargame/levels/" + System.IO.Path.GetFileName(BrowseFile.FileName));
                files = readLevelFolder("C:/Wargame/levels");
                addButtonsToLevelPicker(files);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                if (buttonClicked == true)
                {
                    doc = new XmlDocument();
                    doc.Load(textBoxXMLFile.Text);
                }
            }
        }
    }
}
