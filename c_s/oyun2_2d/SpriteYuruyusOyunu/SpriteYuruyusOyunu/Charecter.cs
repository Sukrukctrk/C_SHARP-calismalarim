using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace SpriteYuruyusOyunu
{
    public class Character
    {
        private Dictionary<string, Texture2D[]> animations;
        private string currentDirection = "Idle";
        private string previousDirection = "Idle";
        private int currentFrame = 0;
        private double timer = 0;
        private double frameInterval = 150; // ms

        public Vector2 Position;
        public float Speed = 100f;

        public Character()
        {
            animations = new Dictionary<string, Texture2D[]>();
            Position = new Vector2(300, 200);
        }

        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            animations["Idle"] = new Texture2D[]
            {
                content.Load<Texture2D>("Character_idle0"),
                content.Load<Texture2D>("Character_idle1"),
                content.Load<Texture2D>("Character_idle2")
            };

            animations["Up"] = new Texture2D[]
            {
                content.Load<Texture2D>("WalkingBackward0"),
                content.Load<Texture2D>("WalkingBackward1"),
                content.Load<Texture2D>("WalkingBackward2"),
                content.Load<Texture2D>("WalkingBackward3")
            };

            animations["Down"] = new Texture2D[]
            {
                content.Load<Texture2D>("WalkingFront0"),
                content.Load<Texture2D>("WalkingFront1"),
                content.Load<Texture2D>("WalkingFront2"),
                content.Load<Texture2D>("WalkingFront3")
            };

            animations["Left"] = new Texture2D[]
            {
                content.Load<Texture2D>("WalkingLeft0"),
                content.Load<Texture2D>("WalkingLeft1"),
                content.Load<Texture2D>("WalkingLeft2")
            };

            animations["Right"] = new Texture2D[]
            {
                content.Load<Texture2D>("WalkingRight0"),
                content.Load<Texture2D>("WalkingRight1"),
                content.Load<Texture2D>("WalkingRight2")
            };
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState key = Keyboard.GetState();
            Vector2 movement = Vector2.Zero;

            if (key.IsKeyDown(Keys.W)) { movement.Y -= 1; currentDirection = "Up"; }
            else if (key.IsKeyDown(Keys.S)) { movement.Y += 1; currentDirection = "Down"; }
            else if (key.IsKeyDown(Keys.A)) { movement.X -= 1; currentDirection = "Left"; }
            else if (key.IsKeyDown(Keys.D)) { movement.X += 1; currentDirection = "Right"; }
            else { currentDirection = "Idle"; }

            if (currentDirection != previousDirection)
            {
                currentFrame = 0;
                timer = 0;
                previousDirection = currentDirection;
            }

            if (movement != Vector2.Zero)
            {
                movement.Normalize();
                Position += movement * Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            timer += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (timer > frameInterval)
            {
                timer = 0;
                currentFrame++;
                if (currentFrame >= animations[currentDirection].Length)
                    currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (animations.ContainsKey(currentDirection))
            {
                var frames = animations[currentDirection];
                if (currentFrame < frames.Length)
                {
                    spriteBatch.Draw(frames[currentFrame], Position, null, Color.White, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0f);

                }
            }
        }
    }
}