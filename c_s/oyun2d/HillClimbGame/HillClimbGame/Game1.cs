using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace HillClimbGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player;
        Terrain terrain;
        List<Coin> coins = new List<Coin>();
        Camera camera;

        Texture2D carTexture;
        Texture2D groundTexture;
        Texture2D coinTexture;

        SpriteFont font;
        int score = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Görselleri yükle
            carTexture = Content.Load<Texture2D>("araç");
            groundTexture = Content.Load<Texture2D>("zemin");
            coinTexture = Content.Load<Texture2D>("coin");

            // Font yüklersen aşağıdaki satırı açabilirsin
            // font = Content.Load<SpriteFont>("defaultFont");

            terrain = new Terrain(groundTexture, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height - groundTexture.Height);

            player = new Player(carTexture, 100, terrain.GroundLevel);

            // Coinleri yere göre hizala
            coins.Add(new Coin(coinTexture, new Vector2(500, terrain.GroundLevel - coinTexture.Height)));
            coins.Add(new Coin(coinTexture, new Vector2(800, terrain.GroundLevel - coinTexture.Height)));
            coins.Add(new Coin(coinTexture, new Vector2(1200, terrain.GroundLevel - coinTexture.Height)));

            camera = new Camera(GraphicsDevice.Viewport);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState ks = Keyboard.GetState();

            // Oyuncu hareketi sadece sağ ok ile
            if (ks.IsKeyDown(Keys.Right))
            {
                player.Position.X += 200f * delta;
            }

            player.Update(gameTime);

            // Kamera oyuncuyu takip eder
            camera.Follow(player.Position);

            // Coin çarpışma kontrolü
            Rectangle playerRect = new Rectangle((int)player.Position.X, (int)player.Position.Y, carTexture.Width, carTexture.Height);

            foreach (var coin in coins)
            {
                if (!coin.Collected)
                {
                    coin.Update(playerRect);
                    if (coin.Collected)
                        score++;
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(transformMatrix: camera.Transform);

            terrain.Draw(spriteBatch, player.Position.X);

            foreach (var coin in coins)
                coin.Draw(spriteBatch);

            player.Draw(spriteBatch);

            spriteBatch.End();

            // Skor gösterimi (font yüklüyse aç)
            /*
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Skor: " + score, new Vector2(10, 10), Color.Black);
            spriteBatch.End();
            */

            base.Draw(gameTime);
        }
    }
}
