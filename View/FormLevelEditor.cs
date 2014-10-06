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
    public partial class FormLevelEditor : Form
    {
        public bool stateToolBox = true;

        public List<Obstacle> ObstacleList { get; set; }

        enum ObjectType
        {
            Mine,
            Mud,
            Sandbag,
            Finish,
            Tree,
            Rocketlauncher
        }

        public FormLevelEditor()
        {
            InitializeComponent();
            ObstacleList = new List<Obstacle>();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1366, 768);
            this.MinimumSize = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
        
            panelMenu.BringToFront();

        }
        private void Mine_MouseDown(object sender, MouseEventArgs e)
        {
            panelMine.DoDragDrop(ObjectType.Mine, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Finish_MouseDown(object sender, MouseEventArgs e)
        {
            panelFinish.DoDragDrop(ObjectType.Finish, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Tree_MouseDown(object sender, MouseEventArgs e)
        {
            panelTree.DoDragDrop(ObjectType.Tree, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Mud_MouseDown(object sender, MouseEventArgs e)
        {
            panelMud.DoDragDrop(ObjectType.Mud, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Sandbag_MouseDown(object sender, MouseEventArgs e)
        {
            panelSandbag.DoDragDrop(ObjectType.Sandbag, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void RocketLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            panelRocketLauncher.DoDragDrop(ObjectType.Rocketlauncher, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void buttonVisable_Click(object sender, EventArgs e)
        {
            if (stateToolBox)
	        {
		         panelToolBox.Show();
	        }
            else
            {
                 panelToolBox.Hide();
            }
            stateToolBox = !stateToolBox;
        }

        private void FormLevelEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ObjectType)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormLevelEditor_DragDrop(object sender, DragEventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);

            switch ((ObjectType)e.Data.GetData(typeof(ObjectType)))
            {
                case ObjectType.Finish:
                    ObstacleList.RemoveAll((o) => { return o.GetType() == typeof(Finish); });
                    ObstacleList.Add(new Finish(p.X, p.Y));
                    break;
                case ObjectType.Mine:
                    ObstacleList.Add(new Mine(p.X, p.Y));
                    break;
                case ObjectType.Mud:
                    ObstacleList.Add(new Mud(p.X, p.Y));
                    break;
                case ObjectType.Rocketlauncher:
                    //TOEVOEGEN!!
                    //ObstacleList.RemoveAll((o) => { return o.GetType() == typeof(Rocketlauncher); });
                    //ObstacleList.Add(new Rocketlauncher(p.X, p.Y));
                    break;
                case ObjectType.Sandbag:
                    ObstacleList.Add(new Sandbag(p.X, p.Y));
                    break;
                case ObjectType.Tree:
                    ObstacleList.Add(new Sandbag(p.X, p.Y));
                    break;
            }
            //MessageBox.Show(string.Format("{0} gedropt at {1}, {2}", (ObjectType)e.Data.GetData(typeof(ObjectType)), p.X, p.Y));
        }

        private void FormLevelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (ObstacleList != null)
            {
                foreach (Obstacle obstacle in ObstacleList)
                {
                    e.Graphics.DrawImage(obstacle.image, obstacle.x, obstacle.y);
                }
            }
        }
    }
}
