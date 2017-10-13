using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block3 : Tetromino
    {
        public Block3(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array3;

        public void CreateArray3()
        {
            Array3 = new int[3,3] {
            {0,0,1},
            {1,1,1},
            {0,0,0}
            
                };
        }

        public void DrawBlock3(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Array3[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.Orange);
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

