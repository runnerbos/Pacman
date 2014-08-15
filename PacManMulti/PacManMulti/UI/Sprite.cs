using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.UI
{
    public abstract class Sprite
    {
        public static string Path { get; set; }
        public static Texture2D Texture { get; set; }
        public Rectangle Location { get; set; }

        public void Initialize(SpriteBatch spriteBatch) {
            
        }

    }
}
