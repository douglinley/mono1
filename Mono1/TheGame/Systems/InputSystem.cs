using InjunEngine.Components;
using InjunEngine.ECS;
using InjunEngine.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Mono1.TheGame.Components;
using System.Collections.Generic;

namespace Mono1.TheGame.Systems
{
    public class InputSystem : SystemBase
    {
        public override void Update(IEnumerable<Entity> entities, GameTime gameTime)
        {
            var kb = Keyboard.GetState();

            foreach (var entity in entities)
            {
                if (!entity.HasComponent<InputComponent>()) continue;

                var velocity = entity.GetComponent<VelocityComponent>();
                if (velocity == null) continue;

                Vector2 direction = Vector2.Zero;

                if (kb.IsKeyDown(Keys.Right) || kb.IsKeyDown(Keys.D))
                    direction.X += 1;
                if (kb.IsKeyDown(Keys.Left) || kb.IsKeyDown(Keys.A))
                    direction.X -= 1;
                if (kb.IsKeyDown(Keys.Down) || kb.IsKeyDown(Keys.S))
                    direction.Y += 1;
                if (kb.IsKeyDown(Keys.Up) || kb.IsKeyDown(Keys.W))
                    direction.Y -= 1;

                if (direction != Vector2.Zero)
                    direction.Normalize();

                float speed = 100f; // Pixels per second
                velocity.Velocity = direction * speed;
            }
        }
    }
}
