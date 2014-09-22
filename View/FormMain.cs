using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame.Controller;
using System.IO;

namespace WarGame.View
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Show();

            CreateDirOnDisk();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormStartGame formStartGame = new FormStartGame();
            formStartGame.ShowDialog();
        }

        public void CreateDirOnDisk() 
        {
            // Specify the directory you want to manipulate. 
            string path = @"c:\WarGame";

            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    Properties.Settings.Default.ImportPath = path;
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path + "\\levels\\");
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                Properties.Settings.Default.ImportPath = path;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
