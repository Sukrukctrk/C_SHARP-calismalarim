using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Project4
{
    public class Spritre
    {
        public Texture2D _textur;
        public Texture2D _textur1;
        public Vector2 _position2;
        public Vector2 _position;

        public Spritre(Texture2D _textur, Texture2D _textur1, Vector2 _Position2, Vector2 _position)
        {
            this._textur = _textur;
            this._textur1 = _textur1;
            this._position = _position;
            this._position2 = _Position2;
        }

        public void update()
        {

        }
        public void Move1()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _position.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position.Y += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _position.X -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _position.X += 1;
            }

            update();
        }

        public void Move2()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                _position2.Y -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                _position2.Y += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                _position2.X -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                _position2.X += 2;
            }
            update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_textur, _position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            spriteBatch.Draw(_textur1, _position2, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
        public void LoadContent(Texture2D texture)
        {
            _textur = texture;
            _textur1 = texture;
        }

        public void Move()
        {
            Move1();
            Move2();
        }



    }
}
