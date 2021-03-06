﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        GameEngine gameEngine;

        public XmlParser(bool clear) 
        {
            if (clear) { 
                gameEngine = GameEngine.Instance();
                gameEngine.level.obstacleList = new List<Obstacle>();
                gameEngine.level.parsedList = new List<Obstacle>();
            }   
        }

        public void ParseMap(XmlDocument doc, ref ProgressBarDialog progressBarDialog) 
        {
            XmlNodeList xmlnode;

            xmlnode = doc.GetElementsByTagName("level_name");
            GameEngine.levelName = xmlnode[0].InnerText;

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
                    case "missilelauncher":
                        Missilelauncher missilelauncher = new Missilelauncher(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(missilelauncher);
                        Console.WriteLine("Missilelauncher added to list.");
                        break;
                    case "tree":
                        Tree tree = new Tree(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(tree);
                        Console.WriteLine("Tree added to list.");
                        break;
                    case "sandbag":
                        Sandbag sandbag = new Sandbag(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(sandbag);
                        Console.WriteLine("Sandbag added to list.");
                        break;
                    case "mine":
                        Mine mine = new Mine(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(mine);
                        Console.WriteLine("Mine added to list.");
                        break;
                    case "mud":
                        Mud mud = new Mud(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(mud);
                        Console.WriteLine("Mud added to list.");
                        break;
                    case "finish":
                        Finish finish = new Finish(xaxis, yaxis);
                        gameEngine.level.parsedList.Add(finish);
                        Console.WriteLine("Finish added to list.");
                        break;
                    default:
                        break;
                }
                progressBarDialog.updateProgressBar(xmlnode.Count, i+1);
            }
            progressBarDialog.Close();
            foreach (Obstacle obstacle in gameEngine.level.parsedList)
            {
                switch (obstacle.ToString())
                {
                    case "WarGame.Model.Mine":
                        gameEngine.level.obstacleList.Add(new Mine(obstacle as Mine));
                        break;
                    case "WarGame.Model.Mud":
                        gameEngine.level.obstacleList.Add(new Mud(obstacle as Mud));
                        break;
                    case "WarGame.Model.Missilelauncher":
                        gameEngine.level.obstacleList.Add(new Missilelauncher(obstacle as Missilelauncher));
                        break;
                    case "WarGame.Model.Tree":
                        gameEngine.level.obstacleList.Add(new Tree(obstacle as Tree));
                        break;
                    case "WarGame.Model.Sandbag":
                        gameEngine.level.obstacleList.Add(new Sandbag(obstacle as Sandbag));
                        break;
                    case "WarGame.Model.Finish":
                        gameEngine.level.obstacleList.Add(new Finish(obstacle as Finish));
                        break;
                }
            }
            gameEngine.LevelImported = true;
        }

        public DataView ParseScore(XmlDocument doc, string l) 
        {
            // Create XMLnode from XMLfile
            XmlNodeList xmlnode = doc.GetElementsByTagName("player");

            // Create Datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("time", typeof(string));
            dataTable.Columns.Add("level", typeof(string));

            // Add nodes from XMLfile to Datatable
            for (int i = 0; i < xmlnode.Count; i++)
            {
                string name = xmlnode[i].ChildNodes.Item(1).InnerText;
                string score = xmlnode[i].ChildNodes.Item(2).InnerText;
                string level = xmlnode[i].ChildNodes.Item(3).InnerText;

                dataTable.Rows.Add(new object[] { name, score, level });
            }

            // Create Dataview from Datatable and set sort and filter
            DataView view = new DataView(dataTable);
            view.Sort = "time ASC";
            view.RowFilter = String.Format("level = '{0}'", l);

            return view;
        }
    }
}
