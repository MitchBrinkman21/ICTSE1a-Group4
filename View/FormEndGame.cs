﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame.View
{
    public partial class FormEndGame : Form
    {
        public string[] scorePlayer = new string[2];
        public FormEndGame(double gameTime)
        {
            InitializeComponent();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {

        }
    }
}
