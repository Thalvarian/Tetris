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

    Vector2 Blockposition;

    Color[] BlockColor = { Color.Black, Color.Cyan, Color.CornflowerBlue, Color.Orange, Color.Yellow, Color.LimeGreen, Color.Purple, Color.Red };
    Color currentColor;

    public int[,] currentBlock;


    public Tetromino(Texture2D b)
    {
        TetBlock = b;
        this.Clear();
        r = new Random();
        currentBlock = createBlock();
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

   
    public void Position(GameTime gameTime)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {                
                Blockposition.Y = i + TetBlock.Height + 20;
                Blockposition.X = j + TetBlock.Width + 12 + 4 * TetBlock.Width;                
            }
    }

   
    class Block1: Tetromino
    {
        public Block1(Texture2D b) : base(b)
        {
            currentBlock = new int[4, 4] { 
            {0,0,0,0},
            {1,1,1,1},      
            {0,0,0,0},
            {0,0,0,0} };            
        }        
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
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
        }
        public int[,] getArray()
        {
            return currentBlock;
        }
    }

    public int[,] createBlock()   /* hij blijft hier een "overflow not handled" ding geven */
    {
        if(r.Next(7) == 0)
        {
            Block1 newArray = new Block1(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[1];
        }
        else if(r.Next(7) == 1)
        {
            Block2 newArray = new Block2(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[2];
        }
        else if(r.Next(7) == 2)
        {
            Block3 newArray = new Block3(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[3]; 
        }
        else if(r.Next(7) == 3)
        {
            Block4 newArray = new Block4(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[4];
        }
        else if(r.Next(7) == 4)
        {
            Block5 newArray = new Block5(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[5];
        }
        else if(r.Next(7) == 5)
        {
            Block6 newArray = new Block6(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[6];
        }
        else if(r.Next(7) == 6)
        {
            Block7 newArray = new Block7(TetBlock);
            currentBlock = newArray.getArray();
            currentColor = BlockColor[7];
        }
        return currentBlock;
    }

    public void Clear()
    {
    }

    public void Draw(GameTime gameTime, SpriteBatch t)
    {

        currentBlock = createBlock();
        int size = currentBlock.GetLength(0);
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                if (currentBlock[i, j] == 1)
                {
                    t.Draw(TetBlock, Blockposition, currentColor);
                    
                }
            }
    }    
    
    public void Reset()
    {        
    }

  
}




