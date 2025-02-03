using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sfml_hello_world.GameLoop;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using SFML.System;


namespace sfml_hello_world.Game
{
    public class TutoGame : GameLoop.GameLoop
    {

        public const uint DEFAULT_WINDOW_WITH = 640;
        public const uint DEFAULT_WINDOW_HEIGHT = 480;

        public TutoGame() : base(DEFAULT_WINDOW_WITH, DEFAULT_WINDOW_HEIGHT, "TutoGame", Color.Blue)
        {
        }

        public override void LoadContent()
        {
            DebugUtility.LoadContent();
        }

        public override void Initialize()
        {

        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(GameTime gameTime)
        {
            DebugUtility.DrawPerformanceData(this, Color.White);
        }
    }
}
