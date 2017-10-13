using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tetris;



class Tetromino
{
    protected Texture2D TetBlock;
    protected Vector2 Blockposition, velocity;
    Tetromino currentBlock;
    const int Height = 4;
    const int Width = 4;
           
    int[,] BlockGrid;

    int[,] GridArray;

    Random r = null;

   

    public Tetromino(Texture2D TetBlock)
    {
        this.TetBlock = TetBlock;
    }


    public void HandleInput(InputHelper inputHelper)
    {
        if (inputHelper.KeyPressed(Keys.Z))
            //roteer linksom
            if (inputHelper.KeyPressed(Keys.X))
                //roteer rechtsom
                if (inputHelper.KeyPressed(Keys.Left) && Blockposition.X > (SCREENWIDTH - TetBlock.Width))
                // hier nog geen rekening gehouden met eventuele blokken die links van het blokje kunnen zijn. Zelfde geldt voor 1 plek naar rechts.
                {
                    Blockposition.X -= TetBlock.Width;
                }
        //1 plek naar links
        if (inputHelper.KeyPressed(Keys.Right) && Blockposition.X < (SCREENWIDTH - TetBlock.Width))
        {
            Blockposition.X += TetBlock.Width;
        }
        //1 plek naar rechts.
        if (inputHelper.KeyPressed(Keys.Down))
        { }
        //snel naar beneden
    }

    public void CreateGrid()
    {
        BlockGrid = new int[Width, Height];
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Blockposition = new Vector2(12 + x * TetBlock.Width, 20 + y * TetBlock.Width);
            }
        }
    }

    public bool IsCollision()
    {
        GridArray = new int[12, 20];
        for (int a = 0; a < 12; a++)
        
            for (int b = 0; b < 20; b++)
            {
                if (GridArray[a, b] > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        return false;
        }
    

    public void IsCurrentBlock()
    {
          
        r = new Random(7);

        if (r.Next() == 0)
        {
            currentBlock = new Block1(TetBlock);
        }
        else if (r.Next() == 1)
        {
            currentBlock = new Block2(TetBlock);
        }
        else if (r.Next() == 2)
        {
            currentBlock = new Block3(TetBlock);
        }
        else if (r.Next() == 3)
        {
            currentBlock = new Block4(TetBlock);
        }
        else if (r.Next() == 4)
        {
            currentBlock = new Block5(TetBlock);
        }
        else if (r.Next() == 5)
        {
            currentBlock = new Block6(TetBlock);
        }
        else
        {
            currentBlock = new Block7(TetBlock);
        }
    }

   
    public void SwitchBlock()
    {}
    

    
    

    public void Update(GameTime gameTime)
    {
        if (gameTime.ElapsedGameTime.Seconds == 1)
        { }
        //positie eentje naar beneden
        //Tetposition.Y += TetBlock.Height;
    }

    public void reset()
    {
        //reset code
    }

  
}



