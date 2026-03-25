using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D karakterSpriteSheet;
        private Vector2 karakterPozisyonu;
        private float hareketHizi = 2f;

        private int frameGenisligi = 32;
        private int frameYuksekligi = 48;
        private int toplamFrame = 4;
        private int aktifFrame = 0;
        private double animasyonZamani = 0;
        private double animasyonHizi = 150; // ms cinsinden: 150ms'de bir kare

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            karakterPozisyonu = new Vector2(400, 300);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            karakterSpriteSheet = Content.Load<Texture2D>("Character_idle0");
        }

        protected override void Update(GameTime gameTime)
        {
            var klavye = Keyboard.GetState();
            bool hareketEdiyor = false;

            if (klavye.IsKeyDown(Keys.Right))
            {
                karakterPozisyonu.X += hareketHizi;
                hareketEdiyor = true;

            }

            if (klavye.IsKeyDown(Keys.Left))
            {
                karakterPozisyonu.X -= hareketHizi;
                hareketEdiyor = true;
            }
            if (klavye.IsKeyDown(Keys.Up))
            {
                karakterPozisyonu.Y -= hareketHizi;
                hareketEdiyor = true;
            }
            if (klavye.IsKeyDown(Keys.Down))
            {
                karakterPozisyonu.Y += hareketHizi;
                hareketEdiyor = true;
            }

            // Eğer hareket ediyorsa animasyonu ilerlet
            if (hareketEdiyor)
            {
                animasyonZamani += gameTime.ElapsedGameTime.TotalMilliseconds;

                if (animasyonZamani >= animasyonHizi)
                {
                    aktifFrame = (aktifFrame + 1) % toplamFrame;
                    animasyonZamani = 0;
                }
            }
            else
            {
                aktifFrame = 0; // Duran karakter için ilk kare
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Rectangle kaynakKare = new Rectangle(aktifFrame * frameGenisligi, 0, frameGenisligi, frameYuksekligi);

            _spriteBatch.Begin();
            _spriteBatch.Draw(karakterSpriteSheet, karakterPozisyonu, kaynakKare, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
