using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project5
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D tileCimen, tileTas, karakterSprite;
        private int tileBoyutu = 32;

        // Harita: 0 = çimen, 1 = taş (engel)
        private int[,] harita = new int[,]
        {
            { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1 },
            { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 },
        };

        private Vector2 karakterPozisyonu = new Vector2(200, 100);
        private float hareketHizi = 3f;

        private Matrix kameraMatrix;

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

            // Karakter sprite'ının adı Character_idle0.png olarak Content klasöründe olmalı
            karakterSprite = Content.Load<Texture2D>("Character_idle0");
        }

        // Karakterin çarpışma kontrolü
        private bool HareketEdebilirMi(Vector2 hedefPozisyon)
        {
            int tileSutun = (int)(hedefPozisyon.X / tileBoyutu);
            int tileSatir = (int)(hedefPozisyon.Y / tileBoyutu);

            int maxSatir = harita.GetLength(0);
            int maxSutun = harita.GetLength(1);

            // Harita sınırları dışında mı?
            if (tileSatir < 0 || tileSatir >= maxSatir ||
                tileSutun < 0 || tileSutun >= maxSutun)
                return false;

            // Eğer taş ise hareket edilemez
            return harita[tileSatir, tileSutun] == 0;
        }

        protected override void Update(GameTime gameTime)
        {
            var klavye = Keyboard.GetState();

            if (klavye.IsKeyDown(Keys.Escape))
                Exit();

            // Yeni pozisyonu hesapla ama önce denetle
            Vector2 yeniPozisyon = karakterPozisyonu;

            if (klavye.IsKeyDown(Keys.Right))
                yeniPozisyon.X += hareketHizi;
            if (klavye.IsKeyDown(Keys.Left))
                yeniPozisyon.X -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Up))
                yeniPozisyon.Y -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Down))
                yeniPozisyon.Y += hareketHizi;

            // Eğer yeni pozisyonda hareket mümkünse uygula
            if (HareketEdebilirMi(yeniPozisyon))
                karakterPozisyonu = yeniPozisyon;

            // Kamera hesaplama: karakter ekran ortasında kalsın
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

            // Haritayı çiz
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

            // Karakteri çiz
            _spriteBatch.Draw(karakterSprite, karakterPozisyonu, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
