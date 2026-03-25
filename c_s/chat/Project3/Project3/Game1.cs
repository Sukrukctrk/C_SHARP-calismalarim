using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project3
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
            { 0, 0, 0, 1, 1, 0, 0, 0 },
            { 0, 1, 1, 1, 0, 0, 1, 1 },
            { 0, 0, 0, 1, 0, 1, 1, 0 },
            { 1, 1, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 1, 1, 1, 0, 0 },
        };

        private Vector2 karakterPozisyonu = new Vector2(100, 100);
        private float hareketHizi = 2.5f;

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

        protected override void Update(GameTime gameTime)
        {
            var klavye = Keyboard.GetState();

            if (klavye.IsKeyDown(Keys.Escape))
                Exit();

            if (klavye.IsKeyDown(Keys.Right))
                karakterPozisyonu.X += hareketHizi;

            if (klavye.IsKeyDown(Keys.Left))
                karakterPozisyonu.X -= hareketHizi;

            if (klavye.IsKeyDown(Keys.Up))
                karakterPozisyonu.Y -= hareketHizi;

            if (klavye.IsKeyDown(Keys.Down))
                karakterPozisyonu.Y += hareketHizi;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Haritayı çiz
            for (int satir = 0; satir < harita.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < harita.GetLength(1); sutun++)
                {
                    int tileTuru = harita[satir, sutun];
                    Vector2 pozisyon = new Vector2(sutun * tileBoyutu, satir * tileBoyutu);

                    if (tileTuru == 0)
                        _spriteBatch.Draw(tileCimen, pozisyon, Color.White);
                    else if (tileTuru == 1)
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
