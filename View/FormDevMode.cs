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
    public partial class FormDevMode : Form
    {
        public FormDevMode()
        {
            InitializeComponent();
        }

        private void updateTimerTick(object sender, EventArgs e)
        {
            List<Obstacle> obstacleList = Controller.GameEngine.Instance().level.obstacleList;
            int i = 0;

            foreach (Obstacle obj in obstacleList)
            {
                ListViewItem lvi = new ListViewItem(i++.ToString());

                lvi = fillLvi(lvi, obj);

                if (obj.ToString().Equals("WarGame.Model.Missile"))
                {
                    Missile m = obj as Missile;
                    lvi.SubItems.Add(m.speed.ToString());
                }

                listView1.Items.Add(lvi);
            }

            ListViewItem plvi = new ListViewItem(i++.ToString());

            plvi.SubItems.Add("WarGame.Model.Player");
            plvi.SubItems.Add(Controller.GameEngine.Instance().level.player.x.ToString());
            plvi.SubItems.Add(Controller.GameEngine.Instance().level.player.y.ToString());
            plvi.SubItems.Add(Controller.GameEngine.Instance().level.player.speed.ToString());
        }

        private static ListViewItem fillLvi(ListViewItem lvi, Obstacle obj)
        {
            lvi.SubItems.Add(obj.ToString());
            lvi.SubItems.Add(obj.x.ToString());
            lvi.SubItems.Add(obj.y.ToString());

            return lvi;
        }
    }
}
