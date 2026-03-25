using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2
{
    public class ScaledSprite : Sprite
    {
        public Rectangle Rect
        {
            get
            {
                int scale = 5;
                return new Rectangle(
                    (int)Position.X,
                    (int)Position.Y,
                    Texture.Width / scale,
                    Texture.Height / scale
                );
            }
        }

        public ScaledSprite(Texture2D texture, Vector2 position)
            : base(texture, position)
        {
        }
    }
}