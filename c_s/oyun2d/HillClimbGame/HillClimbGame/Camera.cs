using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HillClimbGame
{
    public class Camera
    {
        public Matrix Transform { get; private set; }
        private Viewport View;

        public Camera(Viewport viewport)
        {
            View = viewport;
        }

        public void Follow(Vector2 target)
        {
            // Kamerayı hedefin X konumuna göre ortala, Y sabit
            var position = Matrix.CreateTranslation(-target.X + View.Width / 2, 0, 0);
            Transform = position;
        }
    }
}
