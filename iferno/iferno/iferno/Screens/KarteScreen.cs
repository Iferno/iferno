using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace iferno
{
    public class KarteScreen : Screen
    {
        KeyboardState oldKeyboardState = Keyboard.GetState();

        public KarteScreen(Game1 game, SpriteBatch spriteBatch)
            : base(game, spriteBatch)
        {

        }

        public override void activate()
        {
            Settings.player.reset();
            oldKeyboardState = Keyboard.GetState();
        }

        public override void LoadContent()
        {
            Settings.Textures.Add("karte0", Content.Load<Texture2D>("laden/karte0"));
            Settings.Textures.Add("karte1", Content.Load<Texture2D>("laden/karte1"));
            Settings.Textures.Add("karte2", Content.Load<Texture2D>("laden/karte2"));
            Settings.Textures.Add("karte3", Content.Load<Texture2D>("laden/karte3"));
            Settings.Textures.Add("karte4", Content.Load<Texture2D>("laden/karte4"));
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState menuState = Keyboard.GetState();
            if (menuState.IsKeyDown(Keys.Enter) && oldKeyboardState.IsKeyUp(Keys.Enter))
            {
                Settings.game.switchScreen("level");  
            }
            oldKeyboardState = menuState;
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Draw(Settings.Textures["karte" + Settings.mapNumber], new Vector2(0, 0), Color.White);
        }
    }
}
