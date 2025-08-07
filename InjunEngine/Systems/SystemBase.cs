using InjunEngine.ECS;
using Microsoft.Xna.Framework;

namespace InjunEngine.Systems
{
    public abstract class SystemBase
    {
        public abstract void Update(IEnumerable<Entity> entities, GameTime gameTime);
    }
}
