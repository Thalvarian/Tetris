using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block2 : Tetromino
    {
        public Block2(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array2;

        public void CreateArray2()
        {
            Array2 = new int[3, 3] {
            {1,0,0},
            {1,1,1},
            {0,0,0}
            };
        }

        public void DrawBlock3(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Array2[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.CornflowerBlue);
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


