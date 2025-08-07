using InjunEngine.ECS;
using InjunEngine.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Mono1.TheGame;
using Mono1.TheGame.Systems;
using System.Collections.Generic;


namespace Mono1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Entity _player;
        private List<Entity> _entities;
        private InputSystem _inputSystem;
        private MovementSystem _movementSystem;
        private RenderSystem _renderSystem;

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

            _entities = new();
            _inputSystem = new InputSystem();
            _movementSystem = new();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            var texture = Content.Load<Texture2D>("face_dummy");
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _renderSystem = new(_spriteBatch);

            var player = EntityFactory.CreatePlayer(texture, new Vector2(100, 100));
            _entities.Add(player);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _inputSystem.Update(_entities, gameTime);
            _movementSystem.Update(_entities, gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _renderSystem.Draw(_entities);
           
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
