using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Score
    {
        public string nickname;
        public int points;

        public Score(string nickname, int points)
        {
            this.nickname = nickname;
            this.points = points;
        }

        public Score()
        {
            nickname = "noone";
            points = 0;
        }
    }
}
