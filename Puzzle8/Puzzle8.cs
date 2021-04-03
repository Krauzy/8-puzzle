﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle8
{
    public partial class screen_puzzle8 : Form
    {
        private Puzzle p;
        private string flag;
        private Font unable;
        private Font able;
        private Tree root;

        public screen_puzzle8()
        {
            InitializeComponent();
            p = new Puzzle();
            flag = "D";
            able = (Font)depth.Font.Clone();
            unable = (Font)breadth.Font.Clone();
        }

        private string GetValue(int cast)
        {
            if (cast != 0)
                return cast.ToString();
            else
                return string.Empty;
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            this.p = Puzzle.Shuffle(this.p);
            n1.Text = GetValue(p.Puzzle8[0][0].Value);
            n2.Text = GetValue(p.Puzzle8[0][1].Value);
            n3.Text = GetValue(p.Puzzle8[0][2].Value);

            n4.Text = GetValue(p.Puzzle8[1][0].Value);
            n5.Text = GetValue(p.Puzzle8[1][1].Value);
            n6.Text = GetValue(p.Puzzle8[1][2].Value);

            n7.Text = GetValue(p.Puzzle8[2][0].Value);
            n8.Text = GetValue(p.Puzzle8[2][1].Value);
            n9.Text = GetValue(p.Puzzle8[2][2].Value);
        }

        private void change_option()
        {
            if(this.flag == "D")
            {
                depth.Font = this.able;
                depth.BackColor = Color.SlateBlue;
                depth.Size = new Size(depth.Size.Width, 44);
                depth.Location = new Point(133, 371);
                //
                breadth.Font = this.unable;
                breadth.BackColor = Color.FromArgb(64, 64, 64);
                breadth.Size = new Size(breadth.Size.Width, 40);
                breadth.Location = new Point(240, 373);
            }
            else
            {
                depth.Font = this.unable;
                depth.BackColor = Color.FromArgb(64, 64, 64);
                depth.Size = new Size(depth.Size.Width, 40);
                depth.Location = new Point(133, 373);
                //
                breadth.Font = this.able;
                breadth.BackColor = Color.SlateBlue;
                breadth.Size = new Size(breadth.Size.Width, 44);
                breadth.Location = new Point(240, 371);
            }
        }

        private void resolve_Click(object sender, EventArgs e)
        {
            Tree.goals = new Puzzle();
            root = new Tree(this.p);
        }

        private void depth_Click(object sender, EventArgs e)
        {
            this.flag = "D";
            change_option();
        }

        private void breadth_Click(object sender, EventArgs e)
        {
            this.flag = "B";
            change_option();
        }
    }
}