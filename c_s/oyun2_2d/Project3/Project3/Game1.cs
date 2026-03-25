using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Spritre _sprite;
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

            _sprite = new Spritre(Content.Load<Texture2D>("Karakter"),Content.Load<Texture2D>("karakter"), new Vector2(100, 100), new Vector2(200, 200));


        }

        protected override void Update(GameTime gameTime)
        {

            _sprite .Move();
            _sprite.Move1();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_sprite._textur, _sprite._position, null, Color.Red, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);
            _spriteBatch.Draw(_sprite._textur1, _sprite._position2, null, Color.White, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
