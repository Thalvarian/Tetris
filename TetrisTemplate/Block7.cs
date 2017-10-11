using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block7 : Tetromino
    {
        
        public Block7(Texture2D Tetblock) : base(Tetblock)
            {
        }

        int[,] Array7;

        public void CreateArray7()
        {
            Array7 = new int[3,3] {
            {1,1,0},
            {0,1,1},
            {0,0,0}
                };
        }

        public void DrawBlock7(GameTime gameTime, SpriteBatch t)
        {
            CreateGrid();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Array7[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, Color.Red);
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


