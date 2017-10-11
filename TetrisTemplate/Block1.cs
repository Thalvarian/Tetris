using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block1 : Tetromino
    {
        public Block1(Texture2D Tetblock) : base(Tetblock)
            {
            }
        
        int[,] Array1;

        public void CreateArray1()
        {
            Array1 = new int[4, 4] {
            {0,0,0,0},
            {1,1,1,1},
            {0,0,0,0},
            {0,0,0,0}
                };
        }

        public void DrawBlock1(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();
            for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Array1[i, j] == 1)
                        {
                            t.Draw(TetBlock, Blockposition, Color.Cyan);
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
