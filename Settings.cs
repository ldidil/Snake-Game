﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Directions {
        Left, Right, Up, Down
    };
    class Settings{

    public static int Width { get; set; }
    public static int Height { get; set; }
    public static int Speed { get; set; }
    public static int Points { get; set; }
    public static bool GameOver { get; set; }
    public static Directions Direction { get; set; }

    public Settings() {
            Width = 20 ;
            Height = 20;
            Speed = 8;
            Points = 0;
            GameOver = false;
            Direction= Directions.Down;
          }

    }
}
