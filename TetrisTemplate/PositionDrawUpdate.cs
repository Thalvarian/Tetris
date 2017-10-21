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
        Tetromino tet;
        TetrisGrid tgrid;

        Texture2D TetBlock;        
        Vector2 spriteposition;
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

            //for (int i = 0; i < size; i++)
            //    for (int j = 0; j < size; j++)
            //    {
            //        spriteposition.X = i * TetBlock.Width + 12 + 4 * TetBlock.Width;
            //        spriteposition.Y = j * TetBlock.Height + 20;
            //    }

        }

        public void Update(GameTime gameTime)
        {
            //ElapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            //if (ElapsedTime > Steptime)
            //{               
            //        spriteposition.Y += TetBlock.Height;
            //            ElapsedTime = 0;
            //}
        }        

        public void Draw(GameTime gameTime, SpriteBatch t)
        {            
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    spriteposition.X = i * TetBlock.Width + 12 + 4 * TetBlock.Width;
                    spriteposition.Y = j * TetBlock.Height + 20;
                    if (tet.currentBlock[i, j] == 1)
                    {
                        t.Draw(TetBlock, new Rectangle((int)tgrid.Blockposition.X + 
                            ((int)spriteposition.X + i) * TetBlock.Width, (int)tgrid.Blockposition.Y + ((int)spriteposition.Y + j)
                            * TetBlock.Width, TetBlock.Width, TetBlock.Width), new Rectangle(0, 0, 32, 32), tet.currentColor);
                    }  /* klopt nog niet, maar heb t idee dat dit het moet worden */
                }
        }       
    }
}
