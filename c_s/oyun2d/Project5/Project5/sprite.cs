using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project5
{
    public class Sprite
    {
        private Texture2D _texture;
        public Vector2 Position;
        public float Speed = 2f;
        public Input Input;

        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Input == null)
                return;

            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown((Keys)Input.Right)) Position.X += Speed;
            if (keyboardState.IsKeyDown((Keys)Input.Left)) Position.X -= Speed;
            if (keyboardState.IsKeyDown((Keys)Input.Up)) Position.Y -= Speed;
            if (keyboardState.IsKeyDown((Keys)Input.Down)) Position.Y += Speed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, Color.White);
        }
    }
}