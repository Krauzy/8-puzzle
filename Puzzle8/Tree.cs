using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle8
{
    class Tree
    {
        private Puzzle node;
        private List<Tree> children;
        public static Puzzle goals;
        public int H;
        private char first;
        public int pieces;
        public static Stack<Tree> stack = new Stack<Tree>();
        private int step;

        public Puzzle Node { get => this.node; set => this.node = value; }
        public List<Tree> Children { get => this.children; set => this.children = value; }
        public int Step { get => this.step; set => this.step = value; }

        public Tree(Puzzle node, char first, int step = 0)
        {
            this.Step = step;
            this.node = node;
            this.first = first;
            this.children = new List<Tree>();
            // this.pieces = Puzzle.Misplaced(node, Tree.goals);
            this.H = Puzzle.Manhattan(node, Tree.goals);
            // Console.WriteLine(H);
            // node.Show();
        }

        public bool HaveChildren()
        {
            return this.children.Count > 0;
        }

        public void CastChildren()
        {
            int minus = 1000;
            // int pminus = 100;
            foreach(char op in node.Moves)
            {
                if(op != this.first)
                {
                    Tree temp = new Tree(Puzzle.Switch(node, op), Puzzle.InvertOperation(op), Step + 1);
                    minus = (temp.H < minus) ? temp.H : minus;
                    // pminus = (temp.pieces < pminus) ? temp.pieces : pminus;
                    children.Add(temp);
                }
            }
            for (int i = 0; i < children.Count; i++)
            {
                if(children[i].H == minus)
                    Tree.stack.Push(children[i]);
            }
        }
    }
}
