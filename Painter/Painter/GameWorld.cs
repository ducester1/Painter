using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Painter
{
    class GameWorld
    {
        public Texture2D background;
        public Cannon cannon;
        public Ball ball;

        public GameWorld(ContentManager content)
        {
            background = content.Load<Texture2D>("spr_background");
            cannon = new Cannon(content);
            ball = new Ball(content);
        }
        public Cannon Cannon
        {
            get { return cannon; }
        }
        public void HandleInput(InputHelper inputHelper)
        {
            ball.HandleInput(inputHelper);
            cannon.HandleInput(inputHelper);
        }
        public void Reset()
        {
            ball.Reset();
            cannon.Reset();
        }


        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            ball.Draw(gameTime, spriteBatch);
            cannon.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {
            ball.Update(gameTime);
        }
        public bool IsOutsideWorld(Vector2 position)
        {
            return position.X < 0 || position.X > Painter.Screen.X || position.Y > Painter.Screen.Y;
        }

    }
}
