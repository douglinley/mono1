using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mono1
{
    public class Sprite
    {
        public Texture2D Texture { get; set; }

        public Vector2 Origin { get; set; } = Vector2.Zero;

        public float Scale { get; set; }

        public float Rotation { get; set; }

        public Rectangle? SourceRect { get; set; } = null;

        public Color Tint { get; set; } = Color.White;
        

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(
                Texture,
                position,
                SourceRect,
                Tint,
                Rotation,
                Origin,
                Scale,
                SpriteEffects.None,
                0f);
        }
    }
}
