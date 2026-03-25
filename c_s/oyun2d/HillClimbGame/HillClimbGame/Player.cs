using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HillClimbGame
{
    public class Player
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 Velocity;
        private float Gravity = 1000f;
        private float JumpForce = -600f;
        private float GroundY;

        public Player(Texture2D texture, float startX, float groundLevel)
        {
            Texture = texture;
            GroundY = groundLevel;
            Position = new Vector2(startX, GroundY - Texture.Height);
            Velocity = Vector2.Zero;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            // Zıplama kontrolü
            if (keyboardState.IsKeyDown(Keys.Space) && Position.Y >= GroundY - Texture.Height)
            {
                Velocity.Y = JumpForce;
            }

            // Yerçekimi uygulama
            Velocity.Y += Gravity * (float)gameTime.ElapsedGameTime.TotalSeconds;
            Position += Velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Yere sabitle
            if (Position.Y >= GroundY - Texture.Height)
            {
                Position.Y = GroundY - Texture.Height;
                Velocity.Y = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
