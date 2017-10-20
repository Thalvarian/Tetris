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
    const int Height = 4, Width = 4;
    
    


    protected static Random r;

    Vector2 Blockposition, velocity;

    Color[] BlockColor = { Color.Black, Color.Cyan, Color.CornflowerBlue, Color.Orange, Color.Yellow, Color.LimeGreen, Color.Purple, Color.Red };
    Color currentColor;

    static int[,] currentArray, Array;


    List<Array> Blocks;


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



    public void RandomBlock()
    {
        Blocks = new List<Array>();
        
        Blocks.Add(new int[4,4] {
            {0,0,0,0},
            {1,1,1,1},      // Block 1
            {0,0,0,0},
            {0,0,0,0}
            });

        Blocks.Add(new int[4, 4] {
            {1,0,0,0},
            {1,1,1,0},      // Block 2
            {0,0,0,0},
            {0,0,0,0}
            });

        Blocks.Add(new int[4, 4]{
            {0,0,1,0},
            {1,1,1,0},      // Block 3
            {0,0,0,0},
            {0,0,0,0}
                });

        Blocks.Add(new int[4, 4]{
            {1,1,0,0},
            {1,1,0,0},      // Block 4
            {0,0,0,0},
            {0,0,0,0}
            });

        Blocks.Add(new int[4, 4] {
            {1,1,0,0},
            {0,1,1,0},      // Block 5
            {0,0,0,0},
            {0,0,0,0}
                });

        Blocks.Add(new int[4, 4]{
            {0,1,0,0},
            {1,1,1,0},      // Block 6
            {0,0,0,0},
            {0,0,0,0}
                });

        Blocks.Add(new int[4, 4]{
            {1,1,0,0},
            {0,1,1,0},      // Block 7
            {0,0,0,0},
            {0,0,0,0}
                });
        
    
        r = new Random();

        if (r.Next(7) == 0)
        {   
            currentArray = (int[,])Blocks[0].Clone();
            currentColor = BlockColor[1];
            
        }
        else if (r.Next(7) == 1)
        {
            currentArray = (int[,])Blocks[1].Clone();
            currentColor = BlockColor[2];
        }
        else if (r.Next(7) == 2)
        {
            currentArray = (int[,])Blocks[2].Clone();
            currentColor = BlockColor[3];
        }
        else if (r.Next(7) == 3)
        {
            currentArray = (int[,])Blocks[3].Clone();
            currentColor = BlockColor[4];
        }
        else if (r.Next(7) == 4)
        {
            currentArray = (int[,])Blocks[4].Clone();
            currentColor = BlockColor[5];
        }
        else if (r.Next(7) == 5)
        {
            currentArray = (int[,])Blocks[5].Clone();
            currentColor = BlockColor[6];
        }
        else
        {
            currentArray = (int[,])Blocks[6].Clone();
            currentColor = BlockColor[7];
        }
      
        }
    

    public void Position(GameTime gameTime)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                //velocity.Y += TetBlock.Height;
                Blockposition.Y = i * TetBlock.Height + 20;
                Blockposition.X = j * TetBlock.Width + 12 + 4 * TetBlock.Width;

                //Blockposition += velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
    }

    public void Draw(GameTime gameTime, SpriteBatch t)
    {

        //Array = currentArray;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                if (Array[i, j] == 1)
                {
                    t.Draw(TetBlock, Blockposition, currentColor);
                }
            }
    }


    public void Clear()
    {
       
    }
    
    

    public void Update(GameTime gameTime)
    {
        if (gameTime.ElapsedGameTime.Seconds == 1)
        {
            Blockposition.Y += TetBlock.Height;
            
        }
        
    }

    public void reset()
    {
        
    }

  
}




