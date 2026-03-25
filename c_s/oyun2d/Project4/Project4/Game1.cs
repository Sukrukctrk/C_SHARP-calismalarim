using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project4
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Sprite _sprite1;
        private Sprite _sprite2;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            var texture = Content.Load<Texture2D>("Box");

            _sprite1 = new Sprite(texture)
            {
                Position = new Vector2(100, 100),
                Speed = 2f
            };

            _sprite2 = new Sprite(texture)
            {
                Position = new Vector2(200, 200),
                Speed = 3f
            };
        }

        protected override void Update(GameTime gameTime)
        {
            _sprite1.Update();
            _sprite2.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _sprite1.Draw(_spriteBatch);
            _sprite2.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}