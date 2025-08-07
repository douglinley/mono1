using InjunEngine.ECS.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace InjunEngine.Components
{
    public class SpriteComponent : IComponent
    {
        public Texture2D? Texture;
        public Rectangle? SourceRect;
        public float Scale = 1f;
        public float Rotation = 0f;
        public Color Tint = Color.White;
    }
}
