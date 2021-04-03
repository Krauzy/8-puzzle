using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle8
{
    class Puzzle
    {
        public const char UP = 'U';
        public const char DOWN = 'D';
        public const char RIGHT = 'R';
        public const char LEFT = 'L';

        private List<List<Box>> puzzle8;
        private List<char> moves;
        private Point piece;

        public List<List<Box>> Puzzle8 { get => this.puzzle8; set => this.puzzle8 = value; }
        public List<char> Moves { get => this.moves; set => this.moves = value; }

        public Puzzle()
        {
            this.puzzle8 = new List<List<Box>> 
            {
                new List<Box> 
                {
                    new Box(65, 12, 1),
                    new Box(181, 12, 2),
                    new Box(297, 12, 3)
                },
                new List<Box> 
                {
                    new Box(65, 128, 4),
                    new Box(181, 128, 5),
                    new Box(297, 128, 6)
                },
                new List<Box> 
                {
                    new Box(65, 244, 7),
                    new Box(181, 244, 8),
                    new Box(297, 244, 0)
                }
            };
            this.Moves = this.GetMoves();
        }

        public Puzzle(List<List<Box>> puzzle8)
        {
            this.puzzle8 = puzzle8;
            this.Moves = this.GetMoves();
        }

        public void AttMoves()
        {
            this.moves = this.GetMoves();
        }

        public static Puzzle Switch(Puzzle p, char op)
        {
            int x = p.piece.X;
            int y = p.piece.Y;
            int temp = p.puzzle8[x][y].Value;
            List<List<Box>> aux = p.puzzle8;
            switch (op)
            {
                case UP:
                    aux[x][y].Value = aux[x - 1][y].Value;
                    aux[x - 1][y].Value = temp;
                    break;

                case DOWN:
                    aux[x][y].Value = aux[x + 1][y].Value;
                    aux[x + 1][y].Value = temp;
                    break;

                case LEFT:
                    aux[x][y].Value = aux[x][y - 1].Value;
                    aux[x][y - 1].Value = temp;
                    break;

                case RIGHT:
                    aux[x][y].Value = aux[x][y + 1].Value;
                    aux[x][y + 1].Value = temp;
                    break;
            }
            return new Puzzle(aux);
        }

        private List<char> GetMoves()
        {
            List<char> m = new List<char>();
            int x = 0;
            foreach(List<Box> row in this.puzzle8)
            {
                int y = 0;
                foreach(Box cell in row)
                {
                    if(cell.Value == 0)
                    {
                        this.piece = new Point(x, y);
                        if (x == 0)
                            m.Add(DOWN);
                        else if (x == 1)
                        {
                            m.Add(UP);
                            m.Add(DOWN);
                        }
                        else
                            m.Add(UP);

                        if (y == 0)
                            m.Add(RIGHT);
                        else if (y == 1)
                        {
                            m.Add(LEFT);
                            m.Add(RIGHT);
                        }
                        else
                            m.Add(LEFT);
                    }
                    y++;
                }
                x++;
            }
            return m;
        }

        public static Puzzle Shuffle(Puzzle p, int n = 50)
        {
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                int index = rand.Next(0, p.moves.Count);
                p = Puzzle.Switch(p, p.moves[index]);
                p.AttMoves();
            }
            return p;
        }

        public void Show()
        {
            foreach(List<Box> x in this.puzzle8)
            {
                foreach(Box y in x)
                {
                    Console.Write(y.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
