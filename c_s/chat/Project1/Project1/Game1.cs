using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D karakterGorseli;
        private Vector2 karakterPozisyonu;
        private float hareketHizi = 3f;

        private int ekranGenislik, ekranYukseklik;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ekranGenislik = 800;
            ekranYukseklik = 600;

            _graphics.PreferredBackBufferWidth = ekranGenislik;
            _graphics.PreferredBackBufferHeight = ekranYukseklik;
            _graphics.ApplyChanges();

            karakterPozisyonu = new Vector2(400, 300);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            karakterGorseli = Content.Load<Texture2D>("Character_idle0"); // "karakter.png"
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState klavye = Keyboard.GetState();

            if (klavye.IsKeyDown(Keys.Escape))
                Exit();

            // Hareket
            if (klavye.IsKeyDown(Keys.Right))
                karakterPozisyonu.X += hareketHizi;
            if (klavye.IsKeyDown(Keys.Left))
                karakterPozisyonu.X -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Up))
                karakterPozisyonu.Y -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Down))
                karakterPozisyonu.Y += hareketHizi;

            // Sınırlar (karakter ekran dışına çıkmasın)
            int karakterGenislik = karakterGorseli.Width;
            int karakterYukseklik = karakterGorseli.Height;

            karakterPozisyonu.X = MathHelper.Clamp(karakterPozisyonu.X, 0, ekranGenislik - karakterGenislik);
            karakterPozisyonu.Y = MathHelper.Clamp(karakterPozisyonu.Y, 0, ekranYukseklik - karakterYukseklik);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(karakterGorseli, karakterPozisyonu, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
