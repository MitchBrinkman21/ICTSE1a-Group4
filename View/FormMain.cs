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

        GameEngine gameEngine;

        public FormMain()
        {
            InitializeComponent();

            gameEngine = GameEngine.Instance();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Show();

            timerImportState.Enabled = true;

            // Create a directory on C: disk.
            CreateDirOnDisk();
            timer1.Enabled = true;
            gameEngine.OpenIntro();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            gameEngine.StartGame();
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
                DirectoryInfo di2 = Directory.CreateDirectory(path + "\\stats\\");
                DirectoryInfo di3 = Directory.CreateDirectory(path + "\\levels\\levelPreviews\\");
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
            gameEngine.OpenHelp();
        }

        private void buttonImportLevel_Click(object sender, EventArgs e)
        {
            gameEngine.ImportLevel();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            gameEngine.OpenHighscores();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonStart.Enabled = !buttonStart.Enabled;
        }

        private void timerImportState_Tick(object sender, EventArgs e)
        {
            if(gameEngine.LevelImported == true)
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void checkboxDevMode_CheckStateChanged(object sender, EventArgs e)
        {
            gameEngine.DevMode = checkboxDevMode.Checked;
        }

        private void buttonLevelEditor_Click(object sender, EventArgs e)
        {
            FormLevelEditor editor = new FormLevelEditor();
            editor.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameEngine.GameLoopThreadFunction();
        }
    }
}
