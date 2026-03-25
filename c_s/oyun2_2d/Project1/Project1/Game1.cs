using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _texture;
        private Vector2 _position;

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
            _texture = Content.Load<Texture2D>("karakter");  // Doğrudan _texture değişkenine atıyoruz
            _position = new Vector2(100, 100);
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Escape))
                Exit();

            if (key.IsKeyDown(Keys.Right)) _position.X += 3;
            if (key.IsKeyDown(Keys.Left)) _position.X -= 3;
            if (key.IsKeyDown(Keys.Up)) _position.Y -= 3;
            if (key.IsKeyDown(Keys.Down)) _position.Y += 3;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position, null, Color.White, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);  // 5 kat küçültme
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}