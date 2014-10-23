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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = "\r\nThis Game, WarGame 2014, is a stratagy game with a race against the clock!\r\n\r\nTo move the soldier, use your arrow keys on your keyboard.\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTo pause/resume the game press p and to reset the game press R. You can close the game with your ESCAPE key. \r\n\r\n\r\n\r\nFor more information, please see the user manual ";
       
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
