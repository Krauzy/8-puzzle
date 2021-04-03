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
        private List<Tree> childs;
        public static Puzzle goals;
        private int H;

        public Puzzle Node { get => this.node; set => this.node = value; }
        public List<Tree> Childs { get => this.childs; set => this.childs = value; }

        public Tree(Puzzle node)
        {
            this.H = 0;
            this.node = node;
            this.childs = new List<Tree>();
            if (!isEqual(node, goals))
                CastChilds();
        }

        private void CastChilds()
        {
            foreach(char op in node.Moves)
            {
                Tree temp = new Tree(Puzzle.Switch(node, op));
                childs.Add(temp);
            }
        }

        private bool isEqual(Puzzle A, Puzzle B)
        {
            bool result = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    if (A.Puzzle8[i][j].Value != B.Puzzle8[i][j].Value)
                        result = false;
                    else
                        this.H++;
                }
            }
            return result;
        }
    }
}
