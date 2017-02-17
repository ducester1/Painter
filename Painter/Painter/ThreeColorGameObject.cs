using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Painter
{
    class ThreeColorGameObject
    {
        protected Texture2D colorRed, colorGreen, colorBlue;
        protected Texture2D currentColor;
        protected Vector2 position, velocity;
        protected Color color;

        public ThreeColorGameObject(Texture2D colorRed, Texture2D colorGreen, Texture2D colorBlue)
        {
            this.colorRed = colorRed;
            this.colorGreen = colorGreen;
            this.colorBlue = colorBlue;
            Color = Color.Blue;
            position = Vector2.Zero;
            velocity = Vector2.Zero;
        }

        public Color Color
        {
            get { return color; }
            set
            {
                if (value != Color.Red && value != Color.Green && value != Color.Blue)
                    return;
                color = value;
                if (color == Color.Red)
                    currentColor = colorRed;
                else if (color == Color.Green)
                    currentColor = colorGreen;
                else if (color == Color.Blue)
                    currentColor = colorBlue;
            }

        }
    }
}
