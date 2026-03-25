using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2
{
    public class ColorS : ScaledSprite
    {
        public Color color;

        public ColorS(Texture2D texture, Vector2 position, Color color)
            : base(texture, position)
        {
            this.color = color;
        }
    }
}