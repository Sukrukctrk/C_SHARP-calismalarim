using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project6
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D tileCimen, tileTas, karakterSprite;
        private int tileBoyutu = 32;

        // Harita: 0 = çimen, 1 = taş
        private int[,] harita = new int[,]
        {
            { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1 },
            { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 },
        };

        private Vector2 karakterPozisyonu = new Vector2(200, 500);
        private float hareketHizi = 3f;
        private Matrix kameraMatrix;

        // 🌀 Animasyon Değişkenleri
        private int animasyonKareSayisi = 4;
        private int aktifKare = 0;
        private double animasyonSuresi = 150; // ms
        private double animasyonSayaci = 0;

        private SpriteEffects yansima = SpriteEffects.None;
        private int karakterGenislik = 32;
        private int karakterYukseklik = 48;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tileCimen = Content.Load<Texture2D>("cimen");
            tileTas = Content.Load<Texture2D>("tas");
            karakterSprite = Content.Load<Texture2D>("Character_idle0");
        }

        private bool HareketEdebilirMi(Vector2 hedefPozisyon)
        {
            int tileSutun = (int)(hedefPozisyon.X / tileBoyutu);
            int tileSatir = (int)(hedefPozisyon.Y / tileBoyutu);

            int maxSatir = harita.GetLength(0);
            int maxSutun = harita.GetLength(1);

            if (tileSatir < 0 || tileSatir >= maxSatir ||
                tileSutun < 0 || tileSutun >= maxSutun)
                return false;

            return harita[tileSatir, tileSutun] == 0;
        }

        protected override void Update(GameTime gameTime)
        {
            var klavye = Keyboard.GetState();

            if (klavye.IsKeyDown(Keys.Escape))
                Exit();

            Vector2 yeniPozisyon = karakterPozisyonu;

            bool hareketVar = false;

            if (klavye.IsKeyDown(Keys.Right))
            {
                yeniPozisyon.X += hareketHizi;
                yansima = SpriteEffects.None;
                hareketVar = true;
            }
            if (klavye.IsKeyDown(Keys.Left))
            {
                yeniPozisyon.X -= hareketHizi;
                yansima = SpriteEffects.FlipHorizontally;
                hareketVar = true;
            }
            if (klavye.IsKeyDown(Keys.Up))
            {
                yeniPozisyon.Y -= hareketHizi;
                hareketVar = true;
            }
            if (klavye.IsKeyDown(Keys.Down))
            {
                yeniPozisyon.Y += hareketHizi;
                hareketVar = true;
            }

            // Eğer geçerli konumsa uygula
            if (HareketEdebilirMi(yeniPozisyon))
                karakterPozisyonu = yeniPozisyon;

            // Animasyon zamanlayıcı
            if (hareketVar)
            {
                animasyonSayaci += gameTime.ElapsedGameTime.TotalMilliseconds;

                if (animasyonSayaci >= animasyonSuresi)
                {
                    aktifKare++;
                    if (aktifKare >= animasyonKareSayisi)
                        aktifKare = 0;

                    animasyonSayaci = 0;
                }
            }
            else
            {
                aktifKare = 0; // duruyorsa ilk kare
            }

            // Kamera karakteri ortalar
            Vector2 ekranOrtasi = new Vector2(
                _graphics.PreferredBackBufferWidth / 2,
                _graphics.PreferredBackBufferHeight / 2
            );

            kameraMatrix = Matrix.CreateTranslation(new Vector3(-karakterPozisyonu + ekranOrtasi, 0));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(transformMatrix: kameraMatrix);

            for (int satir = 0; satir < harita.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < harita.GetLength(1); sutun++)
                {
                    int tile = harita[satir, sutun];
                    Vector2 pozisyon = new Vector2(sutun * tileBoyutu, satir * tileBoyutu);

                    if (tile == 0)
                        _spriteBatch.Draw(tileCimen, pozisyon, Color.White);
                    else if (tile == 1)
                        _spriteBatch.Draw(tileTas, pozisyon, Color.White);
                }
            }

            // Karakterin o anki sprite karesini al
            Rectangle kaynakKare = new Rectangle(
                aktifKare * karakterGenislik,
                0,
                karakterGenislik,
                karakterYukseklik
            );

            _spriteBatch.Draw(
                karakterSprite,
                karakterPozisyonu,
                kaynakKare,
                Color.White,
                0f,
                Vector2.Zero,
                1f,
                yansima,
                0f
            );

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
