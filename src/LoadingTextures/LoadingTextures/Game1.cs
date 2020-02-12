using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

/// Change the background of the game to show a full size texture instead of color (demonstrating how the Draw method works). 
/// Hide the mouse pointer and replace it with an aiming cross (demonstrating how the Update and Draw methods work).
namespace LoadingTextures
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Texture2D objects that will store the images uploaded to the Content project.
        Texture2D backgroundTexture, mousePointerTexture;

        // Vector2 used to track position of the mouse pointer.
        Vector2 mousePointerPosition;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            #region Step 01
            this.Window.Title = "Introduction to XNA";

            /// Sets the size of the window in which the game will be shown.
            this.graphics.PreferredBackBufferWidth = 1024;
            this.graphics.PreferredBackBufferHeight = 600;
            this.graphics.ApplyChanges();
            #endregion

            /// Hides the mouse pointer.
            /// This property is set to "false" by default.
            this.IsMouseVisible = false;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            /// We load the images from the Content project on our Texture2D properties
            /// in order to show them on screen.
            this.backgroundTexture = Content.Load<Texture2D>(@"Textures\BackgroundImage");
            this.mousePointerTexture = Content.Load<Texture2D>(@"Textures\PointerImage");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            /// Calculates the position and state of the mouse.
            var mouseState = Mouse.GetState();

            /// Sets the position of the pointer texture equal to that of the mouse.
            this.mousePointerPosition = new Vector2(mouseState.X, mouseState.Y);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            #region Step 01
            /// Changes the background color shown on the game window by default when no image is shown.
            GraphicsDevice.Clear(Color.CornflowerBlue);
            //GraphicsDevice.Clear(Color.Yellow);
            //GraphicsDevice.Clear(Color.Black);
            #endregion

            /// Begin the Draw process.
            /// The Begin-End block can be used as many times as wanted.
            /// Each block consumes a lot of resources so try to group the draw as much as possible!
            this.spriteBatch.Begin();
            this.spriteBatch.Draw(this.backgroundTexture, new Rectangle(0, 0, this.backgroundTexture.Width, this.backgroundTexture.Height), Color.White);
            this.spriteBatch.Draw(this.mousePointerTexture, this.mousePointerPosition, Color.Red);
            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
