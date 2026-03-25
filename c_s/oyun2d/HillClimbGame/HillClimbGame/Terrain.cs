using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HillClimbGame
{
    public class Terrain
    {
        private Texture2D texture;
        private int screenWidth;
        private float groundY;

        public float GroundY => groundY; // Dışarıdan erişim için

        public float GroundLevel { get; internal set; }

        public Terrain(Texture2D tex, int viewportWidth, float groundLevel)
        {
            texture = tex;
            screenWidth = viewportWidth;
            groundY = groundLevel;
        }

        public void Draw(SpriteBatch spriteBatch, float cameraX)
        {
            for (float x = -cameraX % texture.Width; x < screenWidth; x += texture.Width)
            {
                spriteBatch.Draw(texture, new Vector2(x, groundY), Color.White);
            }
        }
    }
}
