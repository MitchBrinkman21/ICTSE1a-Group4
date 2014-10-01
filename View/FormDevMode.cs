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

            this.updateViewList();
        }

        private void updateTimerTick(object sender, EventArgs e)
        {
            int index = listView1.TopItem.Index;

            this.updateViewList();

            listView1.TopItem = listView1.Items[index]; 
        }

        private void updateViewList()
        {
            listView1.Items.Clear();

            List<Obstacle> obstacleList = Controller.GameEngine.Instance().level.obstacleList;
            int i = 0;

            foreach (Obstacle obj in obstacleList)
            {
                ListViewItem lvi = new ListViewItem(i++.ToString());

                lvi.SubItems.Add(obj.ToString());
                lvi.SubItems.Add(obj.x.ToString());
                lvi.SubItems.Add(obj.y.ToString());

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

            listView1.Items.Add(plvi);
        }
    }
}
