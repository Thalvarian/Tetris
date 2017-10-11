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

    const int Height = 4;
    const int Width = 4;
           
    int[,] BlockGrid;

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


    public void BlockCalculator()
    {
        
        System.Random r = new System.Random(7);
        if (r.Next() == 0)
        {
            // block 1, nagaan hoe hier de subclass aangeroepen kan worden. Een list van classes schijnt mogelijk te zijn, maar is wat omslachtig. 
        }
        else if (r.Next() == 1)
        {
            // draw Block 2
        }
        else if (r.Next() == 2)
        {
            // draw Block 3
        }
        else if (r.Next() == 3)
        {
            // draw Block 4
        }
        else if (r.Next() == 4)
        {
            // draw Block 5
        }
        else if (r.Next() == 5)
        {
            // draw Block 6
        }
        else
        {
            // draw Block 7
        }
    }

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

    //    public void Update(GameTime gameTime)
    //    {
    //        Tetpostition += (velocity + new Vector2(velocityOffset, 0)) * (float)gameTime.ElapsedGameTime.TotalSeconds;
    //    }

    //    public void Draw(GameTime gameTime, SpriteBatch t)
    //    {
    //        t.Draw(TetBlock, Tetposition, null, Color.Black, 0.0f, originTetBlock, 1.0f, SpriteEffects.None, 0);
    //    }
}



