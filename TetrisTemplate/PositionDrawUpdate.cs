using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Tetris;
using Microsoft.Xna.Framework.Input;

namespace Tetris
{
    class PositionDrawUpdate
    {
        Texture2D TetBlock;
        Tetromino tet;
        Vector2 Blockposition;
        int size;
        public int Steptime = 500;
        int ElapsedTime = 0;
        int MouseElapsedTime = 0;

        public PositionDrawUpdate(Texture2D b)
        {
            tet = new Tetromino();
            TetBlock = b;
            tet.currentBlock = tet.createBlock();
            size = tet.currentBlock.GetLength(0);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    Blockposition.X = i * TetBlock.Width + 12 + 4 * TetBlock.Width;
                    Blockposition.Y = j * TetBlock.Height + 20;
                }

        }

        public void Update(GameTime gameTime)
        {
            ElapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            if (ElapsedTime > Steptime)
            {
               
                    Blockposition.Y += TetBlock.Height;
                        ElapsedTime = 0;
            }
        }
        

        

        public void Draw(GameTime gameTime, SpriteBatch t)
        {            
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {

                    //Blockposition.Y = j * TetBlock.Height + 20;
                    //Blockposition.X = i * TetBlock.Width + 12 + 4 * TetBlock.Width;
                    if (tet.currentBlock[i, j] == 1)
                    {
                        t.Draw(TetBlock, Blockposition, tet.currentColor);
                    }
                }
        }

       
    }
}
