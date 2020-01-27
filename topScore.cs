using SnakeGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Snake
{
    class topScore
    {
        public static List<Score> listScore = new List<Score>();

        public topScore()
        {
            Read();
        }

        public static void Write()
        {
            foreach (Score score in topScore.listScore)
            {
                if (score.points < Settings.Points)
                {
                    listScore.Remove(listScore.Last());
                    listScore.Add(new Score(Settings.Nickname, Settings.Points));
                   
                    break;
                }
                
            }
            listScore = listScore.OrderByDescending(o => o.points).ToList();

        }

        public static void Read()
        { 
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"../../topScores.txt");
            while ((line = file.ReadLine()) != null)
            {
                string n = line;
                int s = Int32.Parse(file.ReadLine());

                listScore.Add(new Score(n, s));
            }
            file.Close();

        }

        public static void Save()
        {
            StreamWriter file = new StreamWriter(@"../../topScores.txt");
            foreach (Score score in topScore.listScore)
            {
                file.WriteLine(score.nickname);
                file.WriteLine(score.points);
            }
            file.Close();

        }
    }

}

