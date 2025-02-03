using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;


namespace sfml_hello_world.Game
{
    public static class DebugUtility
    {
        public const string CONSOLE_FONT_PATH = "./fonts/ARIAL.TTF";

        public static Font? ConsoleFont { get; set; }

        public static void LoadContent()
        {
            ConsoleFont = new Font(CONSOLE_FONT_PATH);
        }

        public static void DrawPerformanceData(GameLoop.GameLoop gameLoop, Color fontColor)
        {
            if (ConsoleFont == null)
            {
                return;
            }

            string totalTimeElapsedStr = gameLoop.GameTime.TotalTimeElapsed.ToString("0.0000");
            string deltaTimeStr = gameLoop.GameTime.DeltaTime.ToString("0.0000");
            float fps = 1f/gameLoop.GameTime.DeltaTime;
            string fpsString = fps.ToString("0.00");

            Text text = new Text(totalTimeElapsedStr, ConsoleFont, 14);
            text.Position = new Vector2f(4f, 8f);
            text.FillColor = fontColor;

            Text textB = new Text(deltaTimeStr, ConsoleFont, 14);
            textB.Position = new Vector2f(4f, 28f);
            textB.FillColor = fontColor;

            Text textC = new Text(fpsString, ConsoleFont, 14);
            textC.Position = new Vector2f(4f, 48f);
            textC.FillColor = fontColor;


            gameLoop.Window.Draw(text);
            gameLoop.Window.Draw(textB);
            gameLoop.Window.Draw(textC);
        }

    }
}
