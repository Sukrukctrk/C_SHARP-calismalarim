using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HillClimbGame
{
    public class Coin
    {
        public Vector2 Position;
        private Texture2D Texture;
        public bool Collected = false;
        private int Size = 32; // Coin hitbox büyüklüğü (sprite boyutu)

        public Coin(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
        }

        public void Update(Rectangle playerRect)
        {
            Rectangle coinRect = new Rectangle((int)Position.X, (int)Position.Y, Size, Size);
            if (coinRect.Intersects(playerRect))
            {
                Collected = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!Collected)
            {
                spriteBatch.Draw(Texture, Position, Color.White);
            }
        }
    }
}
