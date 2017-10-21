using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Tetris;

namespace Tetris
{
    class PositionDrawUpdate
    {
        Texture2D TetBlock;
        Tetromino tet;
        Vector2 Blockposition;
        int[] array;
        int size;

        public PositionDrawUpdate(Texture2D b)
        {
            tet = new Tetromino();
            TetBlock = b;
            tet.currentBlock = tet.createBlock();
            size = tet.currentBlock.GetLength(0);
        }

        public void Position(GameTime gameTime)
        {
            
            //array = new int[4] { 1, 1, 1, 1 };
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    Blockposition.Y = i * TetBlock.Height + 20;
                    Blockposition.X = i * TetBlock.Width + 12 + 4 * TetBlock.Width;
                }
        }

        public void Draw(GameTime gameTime, SpriteBatch t)
        {
            //int size = tet.currentBlock.GetLength(0);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (tet.currentBlock[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, tet.currentColor);

                    }
                }
        }       

        public void Update(GameTime gameTime)
        {
            //if (gameTime.ElapsedGameTime.Seconds == 2)
            //    Blockposition.Y += TetBlock.Height;
        }
    }
}
