using Microsoft.Xna.Framework;
using InjunEngine.Components;
using InjunEngine.ECS;

namespace InjunEngine.Systems
{
    public class MovementSystem : SystemBase
    {
        public override void Update(IEnumerable<Entity> entities, GameTime gameTime)
        {
            foreach (var entity in entities)
            {
                var position = entity.GetComponent<PositionComponent>();
                var velocity = entity.GetComponent<VelocityComponent>();
                if (position == null || velocity == null) continue;

                position.Position += velocity.Velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
    }
}
