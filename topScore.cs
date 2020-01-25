using SnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake
{
    class topScore
    {
        public static ScoreBoard [] boardTab = new ScoreBoard[10];

        public static void Write()
        {
            /*
            if (Settings.HighScores < Settings.Score)
            {
                string High = "" + Settings.Score;
                using (XmlWriter writer = XmlWriter.Create("HighScores.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("HighScore");
                    writer.WriteElementString("HighScore", High);
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            */
        }

        public static void Read()
        {
            int i = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"test.txt");
            while ((line = file.ReadLine()) != null && i<10)
            {
                line = file.ReadLine();
                int line2 = Convert.ToInt32( file.ReadLine());
                boardTab[i] = new ScoreBoard(line2, line);
                i++;
            }

            file.Close();

        }
    }

}

