using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Mono1.Injun.Components;
using System.Collections.Generic;

namespace Mono1.Injun.Systems
{
    public class RenderSystem
    {
        private readonly SpriteBatch _spriteBatch;

        public RenderSystem(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public void Draw(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                var position = entity.GetComponent<PositionComponent>();
                var sprite = entity.GetComponent<SpriteComponent>();
                if (position == null || sprite == null) continue;

                _spriteBatch.Draw(
                    sprite.Texture,
                    position.Position,
                    sprite.SourceRect,
                    sprite.Tint,
                    sprite.Rotation,
                    Vector2.Zero,
                    sprite.Scale,
                    SpriteEffects.None, 0f);
            }
        }
    }
}
