using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _texture;
        private Vector2 _posiation;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = Content.Load<Texture2D>("Box");
            _posiation = new Vector2(0, 0);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _posiation.Y -= 1;
            }

            if( Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _posiation.Y += 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _posiation.X -= 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _posiation.X += 1;
            }   
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();   
            _spriteBatch.Draw(_texture, _posiation, Color.White);
            _spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
