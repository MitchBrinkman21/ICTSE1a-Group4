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
        public string namePlayer
        {
            get { return textBoxName.Text; }
        }
        public FormEndGame(int gameTime)
        {
            InitializeComponent();

            labelTime.Text = Convert.ToString(gameTime);
        } 
    }
}
