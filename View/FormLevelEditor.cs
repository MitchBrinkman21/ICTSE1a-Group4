using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WarGame.Controller;
using WarGame.Model;

namespace WarGame.View
{
    public partial class FormLevelEditor : Form
    {
        public bool stateToolBox = true;
        FormImportLevel importLevel = new FormImportLevel();
        GameEngine gameEngine = new GameEngine();
        XmlDocument doc = null;
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
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
                    ObstacleList.Add(new Tree(p.X, p.Y));
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
                this.Invalidate();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        { 
            loadLevel();
        }

        private void loadLevel()
        {
            OpenFileDialog BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "XML Files (*.xml)|*.xml";
            BrowseFile.FilterIndex = 0;
            BrowseFile.DefaultExt = "xml";
            if (BrowseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = "WarGameLevel.xml";
                string sourcePath = BrowseFile.FileName;
                string targetPath = Properties.Settings.Default.ImportPath + "\\levels\\";
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                string newFile = System.IO.Path.GetFileName(sourcePath);
                if (newFile.Equals("WarGameLevel.xml"))
                {
                    string Text = targetPath + newFile;
                    System.IO.File.Copy(sourcePath, destFile, true);
                    doc = new XmlDocument();
                    try
                    {
                        doc.Load(Text);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Level Could't be read please check your file. Error: " + e, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This File is not a WarGame level. Please try a different file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                XmlNodeList xmlnode;
                xmlnode = doc.GetElementsByTagName("object");
                for (int i = 0; i < xmlnode.Count; i++)
                {
                    string name = xmlnode[i].ChildNodes.Item(0).InnerText;
                    int xaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(1).InnerText);
                    int yaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(2).InnerText);
                    string speed = xmlnode[i].ChildNodes.Item(3).InnerText;
                    switch (name)
                    {
                        case "tree":
                            Tree tree = new Tree(xaxis, yaxis);
                            ObstacleList.Add(tree);
                            Console.WriteLine("Tree added to list.");
                            break;
                        case "sandbag":
                            Sandbag sandbag = new Sandbag(xaxis, yaxis);
                            ObstacleList.Add(sandbag);
                            Console.WriteLine("Tree added to list.");
                            break;
                        case "mine":
                            Mine mine = new Mine(xaxis, yaxis);
                            ObstacleList.Add(mine);
                            Console.WriteLine("Tree added to list.");
                            break;
                        case "mud":
                            Mud mud = new Mud(xaxis, yaxis);
                            ObstacleList.Add(mud);
                            Console.WriteLine("Tree added to list.");
                            break;
                        case "finish":
                            Finish finish = new Finish(xaxis, yaxis);
                            ObstacleList.Add(finish);
                            Console.WriteLine("Tree added to list.");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void buttonNew_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all objects?", "Delete objects", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               ObstacleList.Clear();
            }
        }
    }
}

