using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_1__basics
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        Texture2D dinoTexture;
       
        Texture2D strawBerry;
        Texture2D treeBackgound;
        Texture2D strawBerryAlive;
        Texture2D sword;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            this.Window.Title = "Topic 1 Monogame";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino");
            
            strawBerry = Content.Load<Texture2D>("strawberry");
            treeBackgound = Content.Load<Texture2D>("TreeBackground");
            strawBerryAlive = Content.Load<Texture2D>("Strawberry alive");
            sword = Content.Load<Texture2D>("sword");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(dinoTexture, new Vector2(500, 300), Color.White );
            _spriteBatch.Draw(treeBackgound, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(strawBerry, new Vector2(100, 270), Color.White);
            _spriteBatch.Draw(strawBerry, new Vector2(300, 20), Color.White);
            _spriteBatch.Draw(strawBerry, new Vector2(120, 90), Color.White);
            _spriteBatch.Draw(strawBerryAlive, new Vector2(200, 500), Color.White);
            _spriteBatch.Draw(sword, new Vector2(400, 360), Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
