using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using System;
using Tetris;
using Microsoft.Xna.Framework.Media;

/*
 * A class for representing the game world.
 */
class GameWorld
{
    /*
     * enum for different game states (playing or game over)
     */
    enum GameState
    {
        Playing, GameOver
    }

    /*
     * screen width and height
     */
    int screenWidth, screenHeight;

    /*
     * main game font
     */
    SpriteFont font;
    
    /*
     * sprite for representing a single tetris block element
     */
    public Texture2D block;
    SoundEffect clearRow;
    /*
     * the current game state
     */
    GameState gameState;

    /*
     * the main playing grid
     */
    TetrisGrid grid;
    Tetromino grid2;
    PositionDrawUpdate tetPDU;
   



    public GameWorld(int width, int height, ContentManager Content)
    {
        screenWidth = width;
        screenHeight = height;

        gameState = GameState.Playing;

        block = Content.Load<Texture2D>("block");
        font = Content.Load<SpriteFont>("SpelFont");
        MediaPlayer.Play(Content.Load<Song>("SOUNDTRACK"));
        clearRow = Content.Load<SoundEffect>("CLEAR");


        grid = new TetrisGrid(block);
        grid2 = new Tetromino();
        tetPDU = new PositionDrawUpdate(block);
       

    }

    public void Reset()
    {
    }

    public void HandleInput(GameTime gameTime, InputHelper inputHelper)
    {
    }

    public void Update(GameTime gameTime)
    {
        grid.Update(gameTime);
        tetPDU.Update(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        grid.Draw(gameTime, spriteBatch);
        tetPDU.Draw(gameTime, spriteBatch);
        
        //DrawText("Hello!", Vector2.Zero, spriteBatch);
        spriteBatch.End();
    }

    /*
     * utility method for drawing text on the screen
     */
    public void DrawText(string text, Vector2 positie, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, text, positie, Color.Blue);

    }

    
}
