using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;



namespace Project5
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<Sprite> _sprites;

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
            var texture = Content.Load<Texture2D>("Box");

            _sprites = new List<Sprite>
            {
                new Sprite(texture)
                {
                    Position = new Vector2(100, 100),
                    Input = new Input
                    {
                        Up = (System.Windows.Forms.Keys)Keys.W,
                        Down = (System.Windows.Forms.Keys)Keys.S,
                        Left = (System.Windows.Forms.Keys)Keys.A,
                        Right = (System.Windows.Forms.Keys)Keys.D
                    }
                },
                new Sprite(texture)
                {
                    Position = new Vector2(200, 100),
                    Input = new Input
                    {
                        Up = (System.Windows.Forms.Keys)Keys.Up,
                        Down = (System.Windows.Forms.Keys)Keys.Down,
                        Left = (System.Windows.Forms.Keys)Keys.Left,
                        Right = (System.Windows.Forms.Keys)Keys.Right
                    }
                }
            };
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (var sprite in _sprites)
            {
                sprite.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            foreach (var sprite in _sprites)
            {
                sprite.Draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
