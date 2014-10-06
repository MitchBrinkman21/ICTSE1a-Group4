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
        
        
        public FormLevelEditor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1366, 768);
            this.MinimumSize = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
        
            panelMenu.BringToFront();

        }
        private void Mine_MouseDown(object sender, MouseEventArgs e)
        {

            //Mine.DoDragDrop(this.SelectedClassModel, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Finish_MouseDown(object sender, MouseEventArgs e)
        {
            //Finish.DoDragDrop(ObjectType.SLOWER, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Tree_MouseDown(object sender, MouseEventArgs e)
        {
            //Tree.DoDragDrop(ObjectType.EXPLODE, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Mud_MouseDown(object sender, MouseEventArgs e)
        {
            //Mud.DoDragDrop(ObjectType.TIMEBOMB, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Sandbag_MouseDown(object sender, MouseEventArgs e)
        {
            //Sandbag.DoDragDrop(GetDataPresent(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Rocketlauncher_MouseDown(object sender, MouseEventArgs e)
        {
            //Rocketlauncher.DoDragDrop(ObjectType.HOME, DragDropEffects.Copy | DragDropEffects.Move);
        }

        //private void enter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent())
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}
        //private void drag_drop(object sender, DragEventArgs e)
        //{
        //    // Get location

        //    Point l = null;

        //    // Add object
        //    switch ((Object)e.Data.GetData(typeof(Object)))
        //    {
        //        case ObjectType.TIMEBOMB:
        //            this.pf.AddObject(new EntityTimeBomb(50, 50, l.X, l.Y, 1.0f));
        //            break;
        //        case ObjectType.SLOWER:
        //            this.pf.AddObject(new EntitySlower(50, 50, l.X, l.Y));
        //            break;
        //        case ObjectType.CAKE:
        //            this.pf.GetObjects().RemoveAll((p) => { return p.GetType() == typeof(ObjectFinish); });
        //            this.pf.AddObject(new ObjectFinish(50, 50, l.X, l.Y));
        //            break;
        //        case ObjectType.HOME:
        //            this.pf.GetObjects().RemoveAll((p) => { return p.GetType() == typeof(ObjectStart); });
        //            this.pf.AddObject(new ObjectStart(50, 50, l.X, l.Y));
        //            break;
        //        case ObjectType.CREEPER:
        //            this.pf.AddObject(new EntityCreeper(50, 50, l.X, l.Y, 1.0f));
        //            break;
        //        case ObjectType.OBSTACLE:
        //            this.pf.AddObject(new ObjectObstacle(50, 50, l.X, l.Y));
        //            break;
        //        case ObjectType.EXPLODE:
        //            this.pf.AddObject(new EntityExplode(50, 50, l.X, l.Y, 1.0f));
        //            break;
        //    }
        //}

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

    }
}
