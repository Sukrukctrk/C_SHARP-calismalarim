using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace kendiçalısmam
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Hareket hareket;

        private Dictionary<Keys, Texture2D> textures;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            textures = new Dictionary<Keys, Texture2D>()
            {
                { Keys.A, Content.Load<Texture2D>("WalkingLeft0") },
                { Keys.D, Content.Load<Texture2D>("WalkingRight2") },
                { Keys.W, Content.Load<Texture2D>("WalkingBackward0") },
                { Keys.S, Content.Load<Texture2D>("WalkingBackward0") }
            };

            // Varsayılan texture ile hareket nesnesi oluşturuluyor
            hareket = new Hareket(textures[Keys.D], new Vector2(100, 100));
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();

            foreach (var key in textures.Keys)
            {
                if (ks.IsKeyDown(key))
                {
                    hareket.texture = textures[key];
                }
            }

            hareket.ilerle();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            hareket.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}