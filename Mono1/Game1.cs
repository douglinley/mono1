using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Entity _dummy;

        const float MoveSpeed = 100f;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            _dummy = new(Content.Load<Texture2D>("face_dummy"));
            _dummy.Sprite.Scale = 0.5f;
            _dummy.Position = new Vector2(150, 150);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Vector2 direction = Vector2.Zero;

            // TODO: Add your update logic here
            var kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.D))
            {
                direction.X += 1;
            }

            if (kbState.IsKeyDown(Keys.A))
            {
                direction.X -= 1;
            }

            if (kbState.IsKeyDown(Keys.W))
            {
                direction.Y -= 1;
            }

            if (kbState.IsKeyDown(Keys.S))
            {
                direction.Y += 1;
            }

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
            }

            _dummy.Velocity = direction * _dummy.Speed;

            _dummy.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _dummy.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
