﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Player player = new Player(GameScreen.Size.Width / 2, GameScreen.Size.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
