﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Level
    {
        public List<Obstacle> obstacleList = new List<Obstacle>();
        public Player player;

        public Level()
        {
            player = new Player();
        }
    }
}
