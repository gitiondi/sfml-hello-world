using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfml_hello_world.GameLoop
{
    public class GameTime
    {
        private float _deltaTime = 0f;

        public float TimeScale { get; set; } = 1f;

        public float DeltaTime
        {
            get { return _deltaTime * TimeScale; }
            set { _deltaTime = value; }
        }

        public float DeltaTimeUnscaled
        {
            get { return _deltaTime; }
        }

        public float TotalTimeElapsed { get; private set; }

        public void Update(float deltaTime, float totalTimeElapsed)
        {
            DeltaTime = deltaTime;
            TotalTimeElapsed = totalTimeElapsed;
        }

    }
}
