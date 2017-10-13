using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block6 : Tetromino
    {
        public Block6(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array6;

        public void CreateArray6()
        {
            Array6 = new int[3,3] {
            {0,1,0},
            {1,1,1},
            {0,0,0}
                };
        }

        public void DrawBlock6(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Array6[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.Purple);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}

