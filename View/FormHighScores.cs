﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WarGame.Controller;

namespace WarGame.View
{
    public partial class FormHighScores : Form
    {
        private XmlDocument doc = new XmlDocument();
        private List<string> levels;
        private XmlParser xmlParser = new XmlParser();

        public FormHighScores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHighScores_Load(object sender, EventArgs e)
        {
            buttonDelete.Hide();
            // Load XMLfile if the XMLFile exists
            try
            {
                doc.Load(@"c:\WarGame\stats\Statistics.xml");
            }
            catch (FileNotFoundException)
            {

            }

            // Create XMLnode from XMLfile
            XmlNodeList xmlnode = doc.GetElementsByTagName("player");

            levels = new List<string>();

            // Get levels from XMLfile, distinct levels
            for (int i = 0; i < xmlnode.Count; i++)
            {
                string level = xmlnode[i].ChildNodes.Item(3).InnerText;
                bool answer = true;

                foreach (string l in levels)
                {
                    if (level == l)
                    {
                        answer = false;
                    }
                }

                if (answer)
                {
                    comboBoxLevel.Items.Add(level);
                }

                levels.Add(level);
            }
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLevel.SelectedIndex != -1) 
            {
                // Get level from selected item in combobox
                string level = comboBoxLevel.SelectedItem.ToString();

                // Clear all items in ListView and rows
                listViewHighscores.Items.Clear();

                // Parse score if level is not null
                if (level != null)
                {
                    DataView view = xmlParser.ParseScore(doc, level);

                    int rang = 1;

                     // Add rows from Dataview to List rows and count rang
                    foreach (DataRowView row in view)
                    {
                        ListViewItem lvi = new ListViewItem(rang.ToString());
                        lvi.SubItems.Add(row["name"].ToString());
                        lvi.SubItems.Add(row["time"].ToString());
                        listViewHighscores.Items.Add(lvi);

                        rang++;
                    } 
                }
            }
            buttonDelete.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string level = comboBoxLevel.SelectedItem.ToString();
            bool running = true;
            while (running == true)
            {
                XmlElement el = (XmlElement)doc.SelectSingleNode("/players/player[player_level = '" + level + "']");
                if (el != null) 
                { 
                    el.ParentNode.RemoveChild(el);
                    el = (XmlElement)doc.SelectSingleNode("/players/player[player_level = '" + level + "']");
                    if (el == null)
                    {
                        running = false;
                    }
                }
            }
            doc.Save(@"c:\WarGame\stats\Statistics.xml");
            listViewHighscores.Items.Clear();
            comboBoxLevel.Items.Clear();
            comboBoxLevel.SelectedIndex = -1;
            comboBoxLevel.Text = "Select a level";
            FormHighScores_Load(sender, e);
        }
    }
}
