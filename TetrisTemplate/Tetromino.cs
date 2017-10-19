using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;




class Tetromino
{
    protected Texture2D TetBlock;
    const int Height = 4;
    const int Width = 4;

    static Random r;




    Color[] BlockColor = {Color.Black, Color.Cyan, Color.CornflowerBlue, Color.Orange, Color.Yellow, Color.LimeGreen, Color.Purple, Color.Red};
    Color currentColor;

    public int[,] Array;





    public Tetromino(Texture2D b)
    {
        TetBlock = b;
        
        this.Clear();
    }

    

    //public void HandleInput(InputHelper inputHelper)
    //{
    //    if (inputHelper.KeyPressed(Keys.Z))
    //        //roteer linksom
    //        if (inputHelper.KeyPressed(Keys.X))
    //            //roteer rechtsom
    //            if (inputHelper.KeyPressed(Keys.Left) && Blockposition.X > (SCREENWIDTH - TetBlock.Width))
    //            // hier nog geen rekening gehouden met eventuele blokken die links van het blokje kunnen zijn. Zelfde geldt voor 1 plek naar rechts.
    //            {
    //                Blockposition.X -= TetBlock.Width;
    //            }
    //    //1 plek naar links
    //    if (inputHelper.KeyPressed(Keys.Right) && Blockposition.X < (SCREENWIDTH - TetBlock.Width))
    //    {
    //        Blockposition.X += TetBlock.Width;
    //    }
    //    //1 plek naar rechts.
    //    if (inputHelper.KeyPressed(Keys.Down))
    //    { }
    //    //snel naar beneden
    //}



    //public void CalculateBlockposition()
    //{
    //    Blockposition = new Vector2(10,10);
    //}

    //public bool IsCollision()
    //{
    //    GridArray = new int[12, 20];
    //    for (int a = 0; a < 12; a++)

    //        for (int b = 0; b < 20; b++)
    //        {
    //            if (GridArray[a, b] > 0)
    //            {
    //                return true;
    //            }
    //            else
    //            {
    //                return false;
    //            }
    //        }
    //    return false;
    //    }

   
    
    public void Draw(GameTime gameTime, SpriteBatch t)
    {

        r = new Random(); // (7) determines the output
        if (r.Next(7) == 0)
        {
            Array = new int[4, 4]{
                {0,0,0,0},
                {1,1,1,1},
                {0,0,0,0},
                {0,0,0,0}
            };
            currentColor = BlockColor[1];
        }
        else if (r.Next(7) == 1)
        {
            Array = new int[4, 4] {
            {1,0,0,0},
            {1,1,1,0},
            {0,0,0,0},
            {0,0,0,0}
            };
            currentColor = BlockColor[2]; 
        }
        else if (r.Next(7) == 2)
        {
            Array = new int[4, 4] {
            {0,0,1,0},
            {1,1,1,0},
            {0,0,0,0},
            {0,0,0,0}
                };
            currentColor = BlockColor[3];
        }
        else if (r.Next(7) == 3)
        {
            Array = new int[4, 4] {
            {1,1,0,0},
            {1,1,0,0},
            {0,0,0,0},
            {0,0,0,0}
            };
            currentColor = BlockColor[4];
        }
        else if (r.Next(7) == 4)
        {
            Array = new int[4, 4] {
            {1,1,0,0},
            {0,1,1,0},
            {0,0,0,0},
            {0,0,0,0}
                };
            currentColor = BlockColor[5];
        }
        else if (r.Next(7) == 5)
        {
            Array = new int[4, 4] {
            {0,1,0,0},
            {1,1,1,0},
            {0,0,0,0},
            {0,0,0,0}
                };
            currentColor = BlockColor[6];
        }
        else
        {
            Array = new int[4, 4] {
            {1,1,0,0},
            {0,1,1,0},
            {0,0,0,0},
            {0,0,0,0}
                };
            currentColor = BlockColor[7];
        }
        //Vector2 Blockposition = new Vector2(6, 6);
        //t.Draw(TetBlock, Blockposition, currentColor);
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (Array[i, j] == 1)
                {
                    Vector2 Blockposition;
                    Blockposition.Y = i * TetBlock.Height;
                    Blockposition.X = j * TetBlock.Width;
                    t.Draw(TetBlock, Blockposition, currentColor);
                    
                }
               

            }
            
        }
    }

   
   
    
    public void Clear()
    {
       
    }
    
    

    public void Update(GameTime gameTime)
    {
        if (gameTime.ElapsedGameTime.Seconds == 1)
        { }
        //positie eentje naar beneden
        //Blockposition.Y += TetBlock.Height;
    }

    public void reset()
    {
        
    }

  
}



