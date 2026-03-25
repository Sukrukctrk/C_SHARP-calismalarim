using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace kendiçalısmam
{
    public  class Hareket
    {
        public Texture2D texture;
        Vector2 position;



        public Hareket(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }
    
        public void ilerle()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= 1;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += 1;
            }

            update ();
        }

        public void update() { }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(texture, position, null, Color.White, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0f);
            
        }

        
    }
}
