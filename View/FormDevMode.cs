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
using WarGame.Controller;

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
            int i = 0;

            //Player ListViewItem
            if (GameEngine.Instance().level.player != null)
            {
                ListViewItem plvi = new ListViewItem(i++.ToString());
                plvi.SubItems.Add("Player");
                plvi.SubItems.Add(GameEngine.Instance().level.player.x.ToString());
                plvi.SubItems.Add(GameEngine.Instance().level.player.y.ToString());
                plvi.SubItems.Add(GameEngine.Instance().level.player.speed.ToString());
                listView1.Items.Add(plvi);
            }

            //Missile ListViewItem
            if (GameEngine.Instance().missile != null)
            {
                ListViewItem mlvi = new ListViewItem(i++.ToString());
                mlvi.SubItems.Add("Missile");
                mlvi.SubItems.Add(GameEngine.Instance().missile.x.ToString());
                mlvi.SubItems.Add(GameEngine.Instance().missile.y.ToString());
                mlvi.SubItems.Add(GameEngine.Instance().missile.speed.ToString());
                listView1.Items.Add(mlvi);
            }



            //Print obstacles from obstacleList
            List<Obstacle> obstacleList = new List<Obstacle>();

            foreach (Obstacle obstacle in Controller.GameEngine.Instance().level.obstacleList)
            {
                obstacleList.Add(obstacle);
            }

            foreach (Obstacle obj in obstacleList)
            {
                ListViewItem lvi = new ListViewItem(i++.ToString());

                switch (obj.ToString())
                {
                    case "WarGame.Model.Finish":
                        lvi = fillLvi(lvi, obj, "Finish");
                        break;
                    case "WarGame.Model.Mine":
                        lvi = fillLvi(lvi, obj, "Mine");
                        break;
                    case "WarGame.Model.Mud":
                        lvi = fillLvi(lvi, obj, "Mud");
                        break;
                    case "WarGame.Model.Sandbag":
                        lvi = fillLvi(lvi, obj, "Sandbag");
                        break;
                    case "WarGame.Model.Tree":
                        lvi = fillLvi(lvi, obj, "Tree");
                        break;
                    case "WarGame.Model.Missilelauncher":
                        lvi = fillLvi(lvi, obj, "Missilelauncher");
                        break;
                }

                listView1.Items.Add(lvi);
            }
        }

        private static ListViewItem fillLvi(ListViewItem lvi, Obstacle obj, string naam)
        {
            lvi.SubItems.Add(naam);
            lvi.SubItems.Add(obj.x.ToString());
            lvi.SubItems.Add(obj.y.ToString());

            return lvi;
        }

        private void devButtonUp_MouseDown(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().PressKey(new KeyEventArgs(Keys.Up));
        }

        private void devButtonUp_MouseUp(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().ReleaseKey(new KeyEventArgs(Keys.Up));
        }

        private void devButtonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().PressKey(new KeyEventArgs(Keys.Left));
        }

        private void devButtonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().ReleaseKey(new KeyEventArgs(Keys.Left));
        }

        private void devButtonDown_MouseDown(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().PressKey(new KeyEventArgs(Keys.Down));
        }

        private void devButtonDown_MouseUp(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().ReleaseKey(new KeyEventArgs(Keys.Down));
        }

        private void devButtonRight_MouseDown(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().PressKey(new KeyEventArgs(Keys.Right));
        }

        private void devButtonRight_MouseUp(object sender, MouseEventArgs e)
        {
            GameEngine.Instance().ReleaseKey(new KeyEventArgs(Keys.Right));
        }
    }
}
