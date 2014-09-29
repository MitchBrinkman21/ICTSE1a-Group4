using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WarGame.Model;
using WarGame.View;

namespace WarGame.Controller
{
    public class XmlParser
    {
        public delegate void DoWork(object sender, DoWorkEventArgs e);
        public event DoWork doWork;
        GameEngine gameEngine;

        public XmlParser() 
        {
            gameEngine = GameEngine.Instance();
        }

        public void ParseMap(XmlDocument doc, ref ProgressBarDialog progressBarDialog) 
        {
            XmlNodeList xmlnode;

            xmlnode = doc.GetElementsByTagName("object");
            progressBarDialog.updateProgressBar(xmlnode.Count, 0);

            for (int i = 0; i < xmlnode.Count; i++)
            {
                string name = xmlnode[i].ChildNodes.Item(0).InnerText;
                int xaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(1).InnerText);
                int yaxis = Convert.ToInt32(xmlnode[i].ChildNodes.Item(2).InnerText);
                string speed = xmlnode[i].ChildNodes.Item(3).InnerText;

                switch(name)
                {
                    case "tree":
                        Tree tree = new Tree(xaxis, yaxis);
                        gameEngine.level.obstacleList.Add(tree);
                        Console.WriteLine("Tree added to list.");
                        break;
                    case "sandbag":
                        Sandbag sandbag = new Sandbag(xaxis, yaxis);
                        gameEngine.level.obstacleList.Add(sandbag);
                        Console.WriteLine("Tree added to list.");
                        break;
                    case "mine":
                        Mine mine = new Mine(xaxis, yaxis);
                        gameEngine.level.obstacleList.Add(mine);
                        Console.WriteLine("Tree added to list.");
                        break;
                    case "mud":
                        Mud mud = new Mud(xaxis, yaxis);
                        gameEngine.level.obstacleList.Add(mud);
                        Console.WriteLine("Tree added to list.");
                        break;
                    case "finish":
                        Finish finish = new Finish(xaxis, yaxis);
                        gameEngine.level.obstacleList.Add(finish);
                        Console.WriteLine("Tree added to list.");
                        break;
                    default:
                        break;
                }
                progressBarDialog.updateProgressBar(xmlnode.Count, i+1);
            }
            progressBarDialog.Close();

            gameEngine.LevelImported = true;
        }

        public void ParseScore(XmlDocument doc) 
        { 
        
        }
    }
}
