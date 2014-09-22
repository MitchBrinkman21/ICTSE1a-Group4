using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WarGame.Controller;

namespace WarGame.View
{
    public partial class FormStartGame : Form
    {
        XmlParser xmlParser;    

        public FormStartGame()
        {
            InitializeComponent();

            xmlParser = new XmlParser();

            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void buttonBrowseXML_Click(object sender, EventArgs e)
        {
            Import();
        }

        void Import()
        {
            OpenFileDialog BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "XML Files (*.xml)|*.xml";
            BrowseFile.FilterIndex = 0;
            BrowseFile.DefaultExt = "xml";

            if (BrowseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fileName = "WarGameLevel.xml";
                string sourcePath = BrowseFile.FileName;
                string targetPath = Properties.Settings.Default.ImportPath + "\\levels\\";
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                string newFile = System.IO.Path.GetFileName(sourcePath);

                if (newFile.Equals("WarGameLevel.xml"))
                {
                    textBoxXMLFile.Text = targetPath + newFile;
                    System.IO.File.Copy(sourcePath, destFile, true);
                    MessageBox.Show("Level have successfully been imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    XmlDocument doc = new XmlDocument();
                    try
                    {
                        doc.Load(textBoxXMLFile.Text);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Level Could't be read please check your file. Error: "+ e, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ProgressBarDialog progressBarDialog = new ProgressBarDialog();
                    //progressBarDialog.ShowDialog(this);
                    progressBarDialog.Show();

                    xmlParser.ParseMap(doc, ref progressBarDialog);

                }
                else  
                {
                    MessageBox.Show("This File is not a WarGame level. Please try a different file.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }           
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
