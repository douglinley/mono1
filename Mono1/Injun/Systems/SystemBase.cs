using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Mono1.Injun.Systems
{
    public abstract class SystemBase
    {
        public abstract void Update(IEnumerable<Entity> entities, GameTime gameTime);
    }
}
