using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame.Model;

namespace WarGame.View
{
    public partial class FormGameField : Form
    {
        Level level;
        public FormGameField()
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#66000000");
            panel2.BackColor = color;
            level = Level.Instance();
            if (level.obstacleList != null)
            {
                foreach (Object obstacle in level.obstacleList)
	            {
                    MessageBox.Show(obstacle.ToString());
	            } 
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

    }
}
