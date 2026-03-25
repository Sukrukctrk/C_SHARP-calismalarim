using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Project6
{
    internal class Sprite
    {
        public Texture2D _texture;
        public float _rotation;

        public Vector2 _position;
        public Vector2 _origin;

        public float RotationVelocity = 3f;
        public float LinearVelocity = 4f;


        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public void  Update()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {

                _rotation -= MathHelper.ToRadians(RotationVelocity);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _rotation += MathHelper.ToRadians(RotationVelocity);
            }

           var direction = new Vector2((float)System.Math.Cos(MathHelper.ToRadians(90)-_rotation), (float)System.Math.Sin(MathHelper.ToRadians(90) - _rotation)); // corrected spelling
            direction.Normalize(); // corrected spelling
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _position += direction * LinearVelocity; // corrected spelling      
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position -= direction * LinearVelocity;    
            }
            _origin = new Vector2(_texture.Width / 2f, _texture.Height / 2f);



        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, null, Color.White, _rotation, _origin, 1f, SpriteEffects.None, 0f);
        }
    }
}
