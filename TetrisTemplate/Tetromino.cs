using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


class Tetromino
{
    
    const int Height = 4, Width = 4;
  
    protected static Random r;
    
    

    public Color currentColor;

    public int[,] currentBlock;

       

    public Tetromino()
    {
        r = new Random();
        
    }
     
       
    class Block1: Tetromino
    {
        public Block1()
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
        public Block2()
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
        public Block3()
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
        public Block4()
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
        public Block5()
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
        public Block6()
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
        public Block7()
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

    public int[,] createBlock()   
    {
        if(r.Next(7) == 0)
        {
            Block1 newArray = new Block1();
            currentBlock = newArray.getArray();
            currentColor = Color.Cyan;
        }
        else if(r.Next(7) == 1)
        {
            Block2 newArray = new Block2();
            currentBlock = newArray.getArray();
            currentColor = Color.CornflowerBlue; 
        }
        else if(r.Next(7) == 2)
        {
            Block3 newArray = new Block3();
            currentBlock = newArray.getArray();
            currentColor = Color.Orange; 
        }
        else if(r.Next(7) == 3)
        {
            Block4 newArray = new Block4();
            currentBlock = newArray.getArray();
            currentColor = Color.Yellow; 
        }
        else if(r.Next(7) == 4)
        {
            Block5 newArray = new Block5();
            currentBlock = newArray.getArray();
            currentColor = Color.LimeGreen; 
        }
        else if(r.Next(7) == 5)
        {
            Block6 newArray = new Block6();
            currentBlock = newArray.getArray();
            currentColor = Color.Purple; 
        }
        else
        {
            Block7 newArray = new Block7();
            currentBlock = newArray.getArray();
            currentColor = Color.Red;
        }
        return currentBlock;
    }

    public void Clear()
    {
    }

   
    public void Reset()
    {        
    }

  
}




