using InjunEngine.Components;
using InjunEngine.ECS;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Mono1.TheGame.Components;

namespace Mono1.TheGame
{
    public static class EntityFactory
    {
        public static Entity CreatePlayer(Texture2D texture, Vector2 position)
        {
            Entity player = new();

            player.AddComponent(new PositionComponent { Position = position });
            player.AddComponent(new VelocityComponent { Velocity = Vector2.Zero });
            player.AddComponent(new SpriteComponent { Texture = texture, Scale = .25f, Rotation = 0f, SourceRect = null, Tint = Color.White });
            player.AddComponent(new HealthComponent { Current = 100, Max = 100 });
            player.AddComponent(new InputComponent());

            return player;
        }
    }
}
