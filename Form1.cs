using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food;

        public Form1()
        {
            InitializeComponent();
            new Settings(Form2.nickname,Form2.speed);
            DisplayTopScore();
            gameTimer.Interval = 1000 / Settings.Speed; //TO DO (change speed lvl)
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start(); 

            StartGame();

        }

        private void StartGame()
        {
           Focus();
           GenerateSnake();
           GenerateFood();
        }

        private void GenerateSnake()
        {
            Snake.Clear();
            var head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);
            scorePoint.Text = Settings.Points.ToString();
        }
        private void GenerateFood()
        {
            int maxXpos = boardCanvas.Size.Width / Settings.Width;
            int maxYpos = boardCanvas.Size.Height / Settings.Height;

            Random rand = new Random();
            food = new Circle { X = rand.Next(0, maxXpos), Y = rand.Next(0, maxYpos) };
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver == false)
            {
                if (Input.KeyPress(Keys.Right) && Settings.Direction != Directions.Left)
                {
                    Settings.Direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.Direction != Directions.Right)
                {
                    Settings.Direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.Direction != Directions.Down)
                {
                    Settings.Direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.Direction != Directions.Up)
                {
                    Settings.Direction = Directions.Down;
                }

                MovePlayer();
            }

            boardCanvas.Invalidate();  //odśwież plansze   
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;

                    }

                    checkCollision(i);
                    checkFood();                 
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void checkFood()
        {
            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
            {
                Eat();
            }
        }

        private void checkCollision(int i)
        {
            //with board
            int maxXPos = boardCanvas.Size.Width / Settings.Width;
            int maxYPos = boardCanvas.Size.Height / Settings.Height;

            if (Snake[i].X < 0 || Snake[i].Y < 0 ||
                Snake[i].X > maxXPos || Snake[i].Y > maxYPos)
            {
                Die();
            }

            //with body
            for (int j = 1; j < Snake.Count; j++)
            {
                if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                {
                    Die();
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            Circle body = new Circle
            (
               Snake[Snake.Count - 1].X,
               Snake[Snake.Count - 1].Y
            );
            Snake.Add(body);
            Settings.Points += 10;
            scorePoint.Text = Settings.Points.ToString();
            GenerateFood();
        }

        private void Die()
        {
            topScore.Write();
            Settings.GameOver = true;
        }

        private void UpdateGraphic(object sender, PaintEventArgs e)
        {
            {
                if (!Settings.GameOver)
                {
                    draw(e);                    
                }
                else
                { //game over
                    string gameOver = "Game Over\n" + "Final Score: " + Settings.Points;
                    endText.Text = gameOver;
                    endText.Visible = true;
                    playAgainButton.Visible = true;
                    exitButton.Visible = true;
                }
            }
        }

        private void draw(PaintEventArgs e)
        {

            for (int i = 0; i < Snake.Count; i++)
            {
                string location;
                if (i == 0)
                {
                    location = (@"..\..\Img\snakeHead.png");
                }
                else
                {
                    location = (@"..\..\Img\snakeBody.png");

                }

                var img = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + location);
                Rotate(img);

                Point p1 = new Point(Snake[i].X *Settings.Width, Snake[i].Y * Settings.Height);

                e.Graphics.DrawImage(img, p1);
            }
            Point p2 = new Point(food.X * Settings.Width, food.Y * Settings.Height);
            var appleImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Img\apple.png");
            e.Graphics.DrawImage(appleImage, p2);

        }

        private static void Rotate(Bitmap img)
        {
            switch (Settings.Direction)
            {
                case Directions.Right:
                    break;
                case Directions.Left:
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case Directions.Up:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case Directions.Down:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;

            }
        }

        public void DisplayTopScore()
        {
            topScore top = new topScore();
            int i = 1;
            string text ="";
            foreach (Score score in topScore.listScore) {
                text += score.points + "    " + score.nickname + "\n";
               
                i++;
            }
            topScoreListTxT.Text = text;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            endText.Visible = false;
            playAgainButton.Visible = false;
            exitButton.Visible = false;
            new Settings(Form2.nickname, Form2.speed);

            StartGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            topScore.Save();
            System.Windows.Forms.Application.Exit();
        }

    }

   
}
