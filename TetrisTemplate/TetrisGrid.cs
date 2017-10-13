﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


/*
 * a class for representing the Tetris playing grid
 */
class TetrisGrid 
{
    public TetrisGrid(Texture2D b)
    {
        gridblock = b;
        position = Vector2.Zero;
        this.Clear();
    }
    /*
     * sprite for representing a single grid block
     */
    static Texture2D gridblock;


    const int Width = 12;
    const int Height = 20;
    
    /*
 * the position of the tetris grid
 */
    Vector2 position;
    int[,] TGrid;
        
   
    /*
     * clears the grid
     */
    public void Clear()
    {
    }

    /*
     * draws the grid on the screen
     */
    public void Draw(GameTime gameTime, SpriteBatch s)
        {
        
        TGrid = new int[Width, Height];
        
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {   
                Vector2 position = new Vector2(12 + x * gridblock.Width, 20 + y * gridblock.Width);
                s.Draw(gridblock, position, Color.White);
            }
        }
    }
    //public bool IsBlockDrawn()
    //{
    //    //Color[] retreivedColor = new Color[1];
    //    //target.GetData<Color>(0, TGrid, retreivedColor, 0, maximum);

    //    //if (retreivedColor == Cyan)
    //    if ()
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //public void ClearRow()
    //{

    //    for (int i = 20; i<Height && IsBlockDrawn(); i--)
    //    {
    //        for (int j = 0; j<Width && IsBlockDrawn(); j++)
    //        {
    //            if (12%j == 0)
    //            {
    //                // clear row
    //            }
    //        }
    //    }
    //}
}





