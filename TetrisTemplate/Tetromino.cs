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
    int Steptime = 300;
    int ElapsedTime = 0;
    int KeyboardElapsedTime = 0;
    


    protected static Random r;

    Vector2 Blockposition, velocity;

    Color[] BlockColor = { Color.Black, Color.Cyan, Color.CornflowerBlue, Color.Orange, Color.Yellow, Color.LimeGreen, Color.Purple, Color.Red };
    Color currentColor;

    public int[,] currentArray, currentBlock, Array;


    List<Array> Blocks;


    public Tetromino(Texture2D b)
    {
        TetBlock = b;
        this.Clear();
        r = new Random();

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

   
    //public void randomBlock()
    //{
    //    //Blocks = new List<Array>();
        
    //    //Blocks.Add(new int[4,4] {
    //    //    {0,0,0,0},
    //    //    {1,1,1,1},      // Block 1
    //    //    {0,0,0,0},
    //    //    {0,0,0,0}
    //    //    });

    //    //Blocks.Add(new int[3, 3] {
    //    //    {1,0,0},
    //    //    {1,1,1},      // Block 2
    //    //    {0,0,0},
    //    //    });

    //    //Blocks.Add(new int[3,3]{
    //    //    {0,0,1},
    //    //    {1,1,1},      // Block 3
    //    //    {0,0,0},
    //    //    });

    //    //Blocks.Add(new int[2,2]{
    //    //    {1,1},
    //    //    {1,1},      // Block 4
    //    //    });

    //    //Blocks.Add(new int[3,3] {
    //    //    {1,1,0},
    //    //    {0,1,1},      // Block 5
    //    //    {0,0,0},
    //    //    });

    //    //Blocks.Add(new int[3,3]{
    //    //    {0,1,0},
    //    //    {1,1,1},      // Block 6
    //    //    {0,0,0},
    //    //    });

    //    //Blocks.Add(new int[3,3]{
    //    //    {1,1,0},
    //    //    {0,1,1},      // Block 7
    //    //    {0,0,0},
    //    //    });        
         

    //    //int color = r.Next(0, Blocks.Count);
    //    //currentBlock = (int[,])Blocks[color].Clone();
    //    //int size = currentBlock.GetLength(0);

    //    //for (int i = 0; i < size; i++)
    //    //    for (int j = 0; j < size; j++)
    //    //    {
    //    //        currentBlock[i,j] *= (color + 1);
    //    //        Blockposition = Vector2.Zero;
    //    //    }
    //    if (r.Next(7) == 0)
    //    {
    //        currentArray = new int[4, 4]  {
    //        {0,0,0,0},
    //        {1,1,1,1},      // Block 1
    //        {0,0,0,0},
    //        {0,0,0,0}
    //        };
    //        //currentArray = (int[,])Blocks[0].Clone();
    //        currentColor = BlockColor[1];

    //    }
    //    else if (r.Next(7) == 1)
    //    {
    //        currentArray = new int[3, 3] {
    //        {1,0,0},
    //        {1,1,1},      // Block 2
    //        {0,0,0},
    //        };
    //        //currentArray = (int[,])Blocks[1].Clone();
    //        currentColor = BlockColor[2];
    //    }
    //    else if (r.Next(7) == 2)
    //    {
    //        currentArray = new int[3, 3]{
    //        {0,0,1},
    //        {1,1,1},      // Block 3
    //        {0,0,0},
    //        };
    //        //currentArray = (int[,])Blocks[2].Clone();
    //        currentColor = BlockColor[3];
    //    }
    //    else if (r.Next(7) == 3)
    //    {
    //        currentArray = new int[2, 2]{
    //        {1,1},
    //        {1,1},      // Block 4
    //        };
    //        //currentArray = (int[,])Blocks[3].Clone();
    //        currentColor = BlockColor[4];
    //    }
    //    else if (r.Next(7) == 4)
    //    {
    //        currentArray = new int[3, 3] {
    //        {1,1,0},
    //        {0,1,1},      // Block 5
    //        {0,0,0},
    //        };
    //        //currentArray = (int[,])Blocks[4].Clone();
    //        currentColor = BlockColor[5];
    //    }
    //    else if (r.Next(7) == 5)
    //    {
    //        currentArray = new int[3, 3]{
    //        {0,1,0},
    //        {1,1,1},      // Block 6
    //        {0,0,0},
    //        };
    //        //currentArray = (int[,])Blocks[5].Clone();
    //        currentColor = BlockColor[6];
    //    }
    //    else
    //    {
    //        currentArray = new int[3, 3]{
    //        {1,1,0},
    //        {0,1,1},      // Block 7
    //        {0,0,0},
    //        };
    //        //currentArray = (int[,])Blocks[6].Clone();
    //        currentColor = BlockColor[7];
    //    }
        
    //}
    class Block1: Tetromino
    {
        public Block1(Texture2D b) : base(b)
        {
            currentBlock = new int[4, 4] { 
            {0,0,0,0},
            {1,1,1,1},      
            {0,0,0,0},
            {0,0,0,0} };
            currentColor = BlockColor[1];
        }
    }

    class Block2: Tetromino
    {
        public Block2(Texture2D b) : base(b)
        {
            currentBlock = new int[3, 3]
            {
            {1,0,0},
            {1,1,1},      
            {0,0,0},
            };
            currentColor = BlockColor[2];
        }   
    }

    class Block3 : Tetromino
    {
        public Block3(Texture2D b) : base(b)
        {
            currentBlock = new int[3, 3] { 
            {0,0,1},
            {1,1,1},      
            {0,0,0},};
            currentColor = BlockColor[3];
        }
    }

    class Block4 : Tetromino
    {
        public Block4(Texture2D b) : base(b)
        {
            currentBlock = new int[2, 2]{
            { 1,1},
            { 1,1},      
            };
            currentColor = BlockColor[4];
        }
    }

    class Block5 : Tetromino
    {
        public Block5(Texture2D b) : base(b)
        {
            currentBlock = new int[3, 3]{
            {1,1,0},
            {0,1,1},      
            {0,0,0},
            };
            currentColor = BlockColor[5];
        }
    }

    class Block6 : Tetromino
    {
        public Block6(Texture2D b) : base(b)
        {
            currentBlock = new int[3,3]{
            {0,1,0},
            {1,1,1},      
            {0,0,0},
            };
            currentColor = BlockColor[6];
        }
    }

    class Block7 : Tetromino
    {
        public Block7(Texture2D b) : base(b)
        {
            currentBlock = new int[3,3]{
            {1,1,0},
            {0,1,1},      
            {0,0,0},
            };
            currentColor = BlockColor[7];
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch t)
    {
        
        int size = currentArray.GetLength(0);
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                if (currentArray[i, j] == 1)
                {
                    t.Begin();
                    t.Draw(TetBlock, Blockposition, currentColor);
                    t.End();
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




