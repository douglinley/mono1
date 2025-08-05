using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mono1;

public class Entity
{
    public Sprite Sprite { get; private set; }

    public Vector2 Position { get; set; }

    public Vector2 Velocity { get; set; }

    public float Speed { get; set; } = 100f;

    public Entity(Texture2D texture)
    {
        Sprite = new Sprite
        {
            Texture = texture,
            Rotation = 0,
            Scale = 1.0f
        };
    }

    public void Update(GameTime gameTime)
    {
        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        Position += Velocity * deltaTime;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Sprite?.Draw(spriteBatch, Position);
    }
}
