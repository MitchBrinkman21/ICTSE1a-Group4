using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WarGame.Controller
{
    public class XmlBuilder
    {
        public void CreateFile(string name, string score)
        {
            //create new instance of XmlWriter
            XmlTextWriter writer = new XmlTextWriter(@"c:\WarGame\stats\Statistics.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;

            //create XmlDocument
            writer.WriteStartElement("players");
            writer.WriteStartElement("player");
            writer.WriteStartElement("player_id");
            writer.WriteString("1");
            writer.WriteEndElement();
            writer.WriteStartElement("player_name");
            writer.WriteString(name);
            writer.WriteEndElement();
            writer.WriteStartElement("player_score");
            writer.WriteString(score);
            writer.WriteEndElement();
            writer.WriteStartElement("player_level");
            writer.WriteString(GameEngine.levelName);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            //End of XmlFile and save
            writer.WriteEndDocument();
            writer.Close();
        }

        public void ChangeFile(string name, string score)
        {
            //file name
            string filename = @"c:\WarGame\stats\Statistics.xml";

            //create new instance of XmlDocument
            XmlDocument doc = new XmlDocument();
            
            //load from file
            doc.Load(filename);

            //create node and add value
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "player", null);

            //get max player_id from XML file and count 1
            XmlNode player = doc.SelectSingleNode("//player/player_id[not(. <=../preceding-sibling::player/player_id) and not(. <=../following-sibling::player/player_id)]");
            int player_id;

            if (player == null)
            {
                player_id = 1;
            }
            else
            {
                player_id = Convert.ToInt32(player.InnerText) + 1;
            }

            //create player_id node
            XmlNode nodeId = doc.CreateElement("player_id");
            nodeId.InnerText = player_id.ToString();

            //create player_name node
            XmlNode nodeName = doc.CreateElement("player_name");
            nodeName.InnerText = name;

            //create player_score node
            XmlNode nodeScore = doc.CreateElement("player_score");
            nodeScore.InnerText = score;

            //create player_level node
            XmlNode nodeLevel = doc.CreateElement("player_level");
            nodeLevel.InnerText = GameEngine.levelName;

            //add to parent node
            node.AppendChild(nodeId);
            node.AppendChild(nodeName);
            node.AppendChild(nodeScore);
            node.AppendChild(nodeLevel);

            //add to elements collection
            doc.DocumentElement.AppendChild(node);

            //save back
            doc.Save(filename);
        }
    }
}
