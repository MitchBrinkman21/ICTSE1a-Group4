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
using System.IO;
using WarGame.Controller;
using WarGame.Model;
using System.Drawing.Imaging;

namespace WarGame.View
{
    public partial class FormLevelEditor : Form
    {
        public bool showToolBox = true;
        FormImportLevel importLevel = new FormImportLevel();
        GameEngine gameEngine;
        XmlDocument doc = null;
        Obstacle currentMovingObject;
        Point movingPoint = Point.Empty;
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
            panelMenu.Location = new Point(this.Width - panelMenu.Width, 0);
            panelToolBox.Location = new Point(this.Width - panelToolBox.Width, panelMenu.Height);
            this.StartPosition = FormStartPosition.CenterScreen;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(0x66141414);
            gameEngine = GameEngine.Instance();
            panelMenu.BringToFront();
        }
        //enable double buffered for menu
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        //eventhandling of the objects in the toolbox
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

        //event button hiding/showing the toolbox
        private void buttonVisable_Click(object sender, EventArgs e)
        {
            showToolBox = !showToolBox;
            if (showToolBox)
            {
                panelToolBox.Show();
            }
            else
            {
                panelToolBox.Hide();
            }
        }
        //place objects in gamefield
        private void FormLevelEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ObjectType)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //adding the chosen objects to the object list
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
                    ObstacleList.Add(new Missilelauncher(p.X, p.Y));
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

        //showing placed object in the gamefield
        private void FormLevelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (ObstacleList != null)
            {
                List<Mine> mines = new List<Mine>();
                List<Tree> trees = new List<Tree>();
                List<Sandbag> sandbags = new List<Sandbag>();
                List<Mud> muds = new List<Mud>();
                List<Missilelauncher> missilelaunchers = new List<Missilelauncher>();
                Finish finish = new Finish(-50, -50);
                foreach (Obstacle obstacle in ObstacleList)
                {
                    switch (obstacle.ToString())
                    {
                        case "WarGame.Model.Mine":
                            mines.Add(obstacle as Mine);
                            break;
                        case "WarGame.Model.Tree":
                            trees.Add(obstacle as Tree);
                            break;
                        case "WarGame.Model.Sandbag":
                            sandbags.Add(obstacle as Sandbag);
                            break;
                        case "WarGame.Model.Mud":
                            muds.Add(obstacle as Mud);
                            break;
                        case "WarGame.Model.Missilelauncher":
                            missilelaunchers.Add(obstacle as Missilelauncher);
                            break;
                        case "WarGame.Model.Finish":
                            finish = obstacle as Finish;
                            break;
                    }
                }
                foreach (Mud mud in muds)
                {
                    e.Graphics.DrawImage(mud.image, mud.x, mud.y);
                    if (gameEngine.DevMode)
                    {
                        e.Graphics.DrawRectangle(Pens.Red, mud.rect);
                    }
                }
                foreach (Sandbag sandbag in sandbags)
                {
                    e.Graphics.DrawImage(sandbag.image, sandbag.x, sandbag.y);
                    if (gameEngine.DevMode)
                    {
                        e.Graphics.DrawRectangle(Pens.Yellow, sandbag.rect);
                    }
                }
                foreach (Tree tree in trees)
                {
                    e.Graphics.DrawImage(tree.image, tree.x, tree.y);
                    if (gameEngine.DevMode)
                    {
                        e.Graphics.DrawRectangle(Pens.Green, tree.rect);
                    }
                }
                foreach (Mine mine in mines)
                {                    
                    e.Graphics.DrawImage(mine.image, mine.x, mine.y);                        
                    if (gameEngine.DevMode)
                    {
                        e.Graphics.DrawRectangle(Pens.Red, mine.rect);
                    }
                }
                foreach (Missilelauncher missilelauncher in missilelaunchers)
                {                    
                    e.Graphics.DrawImage(missilelauncher.image, missilelauncher.x, missilelauncher.y);
                    if (gameEngine.DevMode)
                    {
                        e.Graphics.DrawRectangle(Pens.Red, missilelauncher.rect);
                    }
                }
                e.Graphics.DrawImage(finish.image, finish.x, finish.y);
                if (gameEngine.DevMode)
                {
                    e.Graphics.DrawRectangle(Pens.Blue, finish.rect);
                }
                //painting player
                Player player = new Player();
                e.Graphics.DrawImage(player.image, (int)(player.x - (player.width * (player.scale / 200))), (int)(player.y - (player.height * (player.scale / 200))));

                if (gameEngine.DevMode)
                {
                    e.Graphics.DrawRectangle(Pens.Blue, player.rect);
                }
                this.Invalidate();
            }
        }
        //saving the gamefield with chosen objects
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveLevel(ObstacleList);
        }

        //opening dialogs to save the gamefield
        private void saveLevel(List<Obstacle> obstacleList)
        {
            //check if final has been added
            bool finAdded = false;
            foreach (Obstacle obstacle in obstacleList)
            {
                if (obstacle.ToString().Equals("WarGame.Model.Finish"))
                {
                    finAdded = true;
                }
            }
            if (!finAdded)
            {
                MessageBox.Show("You have to add a finish to the level.");
            }
            else
            {
                FormLevelEditorNameDialog nameDlg = new FormLevelEditorNameDialog();
                DialogResult result = nameDlg.ShowDialog();
                string defLocation = "C:/WarGame/levels/levelPreviews/";
                string defExt = ".jpg";
                if (result == DialogResult.OK)
                {
                    SaveFileDialog SaveFile = new SaveFileDialog();
                    SaveFile.FileName = nameDlg.levelName;
                    SaveFile.Filter = "XML Files (*.xml)|*.xml";
                    SaveFile.FilterIndex = 0;
                    SaveFile.DefaultExt = "xml";
                    if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        createXmlLevelFile(SaveFile.FileName, nameDlg.levelName, ObstacleList); 
                        screenshotLevel(defLocation + nameDlg.levelName + defExt);
                    }
                }
            }
        }
        //making a image for the levelpreview in levels form
        private void screenshotLevel(string location)
        {
            var frm = Form.ActiveForm;
            panelToolBox.Hide();
            panelMenu.Hide();
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(location);
            }
            panelToolBox.Show();
            panelMenu.Show();
        }
        private void createXmlLevelFile(string filePath, string name, List<Obstacle> obstacleList)
        {
            //create new instance of XmlWriter
            XmlTextWriter writer = new XmlTextWriter(string.Format(@"{0}", filePath), System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;

            //create XmlDocument
            writer.WriteStartElement("wargamelevel");
            writer.WriteStartElement("level_name");
            writer.WriteString(name);
            writer.WriteEndElement();
            writer.WriteStartElement("objects");

            foreach (Obstacle obstacle in obstacleList)
            {
                writer.WriteStartElement("object");

                //objecttype
                writer.WriteStartElement("object_type");
                switch (obstacle.ToString())
                {
                    case "WarGame.Model.Finish":
                        writer.WriteString("finish");
                        break;
                    case "WarGame.Model.Mine":
                        writer.WriteString("mine");
                        break;
                    case "WarGame.Model.Mud":
                        writer.WriteString("mud");
                        break;
                    case "WarGame.Model.Sandbag":
                        writer.WriteString("sandbag");
                        break;
                    case "WarGame.Model.Tree":
                        writer.WriteString("tree");
                        break;
                    case "WarGame.Model.Missilelauncher":
                        writer.WriteString("missilelauncher");
                        break;
                }
                writer.WriteEndElement();

                writer.WriteStartElement("object_x");
                writer.WriteString(obstacle.x.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("object_y");
                writer.WriteString(obstacle.y.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("object_speed");
                writer.WriteString("0");
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndElement();

            //End of XmlFile and save
            writer.WriteEndDocument();
            writer.Close();
        }

        //button event for loading existing level
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadLevel();
        }

        //opening the dialogs for choosing an existing level
        private void loadLevel()
        {
            OpenFileDialog BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "XML Files (*.xml)|*.xml";
            BrowseFile.FilterIndex = 0;
            BrowseFile.DefaultExt = "xml";
            if (BrowseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ObstacleList.Clear();
                doc = new XmlDocument();
                try
                {
                    doc.Load(BrowseFile.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Level Could't be read please check your file. Error: " + e, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                XmlNodeList xmlnode;
                xmlnode = doc.GetElementsByTagName("object");
                for (int i = 0; i < xmlnode.Count; i++)
                {
                    string name = xmlnode[i].ChildNodes.Item(0).InnerText;
                    int xaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(1).InnerText);
                    int yaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(2).InnerText);
                    string speed = xmlnode[i].ChildNodes.Item(3).InnerText;
                    //adding the objects to the object list
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
                        case "missilelauncher":
                            ObstacleList.Add(new Missilelauncher(xaxis, yaxis));
                            Console.WriteLine("Missilelauncher added to list.");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        //button event for deleting all object from gamefield
        private void buttonNew_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all objects?", "Delete objects", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               ObstacleList.Clear();
            }
        }
        //managing already placed objects on the gamefield
        private void FormLevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);
            foreach (Obstacle obstacle in ObstacleList)
            {
                if (p.X >= obstacle.x && p.X <= (obstacle.x+obstacle.width) && p.Y >= obstacle.y && p.Y <= (obstacle.y +obstacle.length))
                {
                    currentMovingObject = obstacle;
                }
            }
            if (this.currentMovingObject != null)
            {
                this.movingPoint = new Point(p.X - this.currentMovingObject.x, p.Y - this.currentMovingObject.y);

                if (e.Button == MouseButtons.Left)
                    panelToolBox.Hide();
            }
            if (e.Button == MouseButtons.Right)
            {
                ObstacleList.Remove(currentMovingObject);
            }
        }

        //moving already placed objects on the gamefield
        private void FormLevelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.currentMovingObject != null)
            {
                Point p = this.PointToClient(Cursor.Position);
                this.currentMovingObject.x = p.X - this.movingPoint.X;
                this.currentMovingObject.y = p.Y - this.movingPoint.Y;
                this.currentMovingObject.rect.Location = new Point(p.X - this.movingPoint.X, p.Y - this.movingPoint.Y);
                this.Invalidate();
            }
        }
        //hiding the toolbox while moving already placed objects on the gamefield
        private void FormLevelEditor_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.currentMovingObject != null)
            {
                this.currentMovingObject = null;

                if (showToolBox)
                    panelToolBox.Show();
            }
        }
        //closing the editor when pressed esc
        private void FormLevelEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

