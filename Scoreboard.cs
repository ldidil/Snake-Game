namespace Snake
{
    public class ScoreBoard
    {
        int score { set; get; }
        string nickname { set; get; }

        public ScoreBoard(int score, string nickname)
        {
            this.score = score;
            this.nickname = nickname;
        }
        public ScoreBoard()
        {
            this.score = 0;
            this.nickname = "";
        }
    }
}