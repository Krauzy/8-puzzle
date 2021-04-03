using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle8
{
    class Box
    {
        private Point location;
        private int value;

        public Point Location { get => this.location; set => this.location = value; }
        public int Value { get => this.value; set => this.value = value; }

        public Box(int x, int y, int value)
        {
            this.location = new Point(x, y);
            this.value = value;
        }
    }
}
