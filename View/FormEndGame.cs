using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame.View
{
    public partial class FormEndGame : Form
    {
        public string namePlayer
        {
            get { return textBoxName.Text; }
        }
        public bool close;
        public FormEndGame(double gameTime)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            TimeSpan t = TimeSpan.FromMilliseconds(gameTime);

            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                            t.Hours,
                            t.Minutes,
                            t.Seconds,
                            t.Milliseconds);
            labelTime.Text = answer;
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                close = true;
                this.Close();
            }
            else
            {
                close = false;
            }
        } 
    }
}
