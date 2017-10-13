using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block5 : Tetromino
    {
        public Block5(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array5;

        public void CreateArray5()
        {
            Array5 = new int[3, 3] {
            {1,1,0},
            {0,1,1},
            {0,0,0}
                };
        }

        public void DrawBlock5(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Array5[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.LimeGreen);
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

