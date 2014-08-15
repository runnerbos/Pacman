using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.UI
{
    public abstract class View
    {
        // Fill in for all View elements to implement from

        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Initialize(Microsoft.Xna.Framework.Game Game);

        public abstract void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
