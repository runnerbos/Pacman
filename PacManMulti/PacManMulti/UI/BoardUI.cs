using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PacManMulti.UI
{
    public class BoardUI : View
    {

        List<Sprite> Sprites = new List<Sprite>();

        public BoardUI(Logic.Board board)
        {
            Sprites.Add(new SpriteDemo());
        }

        public override void Initialize(Microsoft.Xna.Framework.Game Game)
        {
            foreach(Sprite Sprite in Sprites){
                Sprite.Texture = Game.Content.Load<Texture2D>("./images/" + Sprite.Path);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach (Sprite Sprite in Sprites)
            {
                spriteBatch.Draw(Sprite.Texture, Vector2.Zero, Color.White);
            }
            spriteBatch.End();
        }
    }
}
