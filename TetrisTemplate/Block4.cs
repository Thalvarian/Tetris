using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block4 : Tetromino
    {
        public Block4(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array4;

        public void CreateArray4()
        {
            Array4 = new int[2,2] {
            {1,1},
            {1,1},
            };
        }

        public void DrawBlock4(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Array4[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.Yellow);
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
