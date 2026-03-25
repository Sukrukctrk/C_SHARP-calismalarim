using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project4
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics; // Grafik ayarlarını yöneten sınıf
        private SpriteBatch _spriteBatch;        // Sprite’ları ekrana çizmek için

        private Texture2D tileCimen, tileTas, karakterSprite; // Görsel dosyalar
        private int tileBoyutu = 32;                          // Tile (karolama) boyutu

        // Harita verisi (0: çimen, 1: taş)
        private int[,] harita = new int[,]
        {
            { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1 },
            { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 },
        };

        private Vector2 karakterPozisyonu = new Vector2(200, 100); // Karakterin dünya üzerindeki konumu
        private float hareketHizi = 3f;                             // Karakterin hareket hızı

        private Matrix kameraMatrix; // Kamera dönüşüm matrisi

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);       // Grafik cihaz yöneticisi
            Content.RootDirectory = "Content";                 // İçerik dizini
            IsMouseVisible = true;                             // Fare imlecini göster
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800; // Ekran genişliği
            _graphics.PreferredBackBufferHeight = 600; // Ekran yüksekliği
            _graphics.ApplyChanges();                 // Değişiklikleri uygula

            base.Initialize(); // Ana oyun başlatıcısını çağır
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice); // Sprite çizim sınıfı

            // Görselleri yükle (Content klasöründe olmalı)
            tileCimen = Content.Load<Texture2D>("cimen");
            tileTas = Content.Load<Texture2D>("tas");
            karakterSprite = Content.Load<Texture2D>("Character_idle0");
        }

        protected override void Update(GameTime gameTime)
        {
            var klavye = Keyboard.GetState(); // Klavye durumu

            // ESC tuşuna basılırsa oyundan çık
            if (klavye.IsKeyDown(Keys.Escape))
                Exit();

            // Yön tuşlarına göre hareket
            if (klavye.IsKeyDown(Keys.Right))
                karakterPozisyonu.X += hareketHizi;
            if (klavye.IsKeyDown(Keys.Left))
                karakterPozisyonu.X -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Up))
                karakterPozisyonu.Y -= hareketHizi;
            if (klavye.IsKeyDown(Keys.Down))
                karakterPozisyonu.Y += hareketHizi;

            // Kamera karakteri ortalar
            Vector2 ekranOrtasi = new Vector2(
                _graphics.PreferredBackBufferWidth / 2,
                _graphics.PreferredBackBufferHeight / 2
            );

            // Kamera matrisi: karakteri ortalayacak şekilde haritayı ters yönde kaydırır
            Vector2 tersPozisyon = -karakterPozisyonu + ekranOrtasi;
            kameraMatrix = Matrix.CreateTranslation(new Vector3(tersPozisyon, 0));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); // Arka plan rengini temizle

            _spriteBatch.Begin(transformMatrix: kameraMatrix); // Kamera ile çizime başla

            // Harita çizimi
            for (int satir = 0; satir < harita.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < harita.GetLength(1); sutun++)
                {
                    int tileTuru = harita[satir, sutun]; // Hücre tipi
                    Vector2 pozisyon = new Vector2(sutun * tileBoyutu, satir * tileBoyutu); // Tile ekran pozisyonu

                    // Görsel çiz
                    if (tileTuru == 0)
                        _spriteBatch.Draw(tileCimen, pozisyon, Color.White);
                    else if (tileTuru == 1)
                        _spriteBatch.Draw(tileTas, pozisyon, Color.White);
                }
            }

            // Karakter çizimi (kamera sayesinde ekranda sabit durur)
            _spriteBatch.Draw(karakterSprite, karakterPozisyonu, Color.White);

            _spriteBatch.End(); // Çizimi bitir

            base.Draw(gameTime); // Temel çizim çağrısı
        }
    }
}
