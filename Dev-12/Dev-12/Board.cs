using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Dev_12
{
    class Board
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        public const int EMPTY = 0;

        public Square[,] square = new Square[8, 8];

        public Board()
        {
            int i, j;            
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    this.square[i, j] = new Square();
                    if ((i + j) % 2 == 0)
                    {
                        this.square[i, j].Color = BLACK;
                    }
                    else
                    {
                        this.square[i, j].Color = WHITE;
                    }
                    int[] location = { i, j };
                    this.square[i, j].Location = location;
                    this.square[i, j].State = EMPTY;
                    this.square[i, j].Index = i*j;
                }
            }
        }
    }
}
