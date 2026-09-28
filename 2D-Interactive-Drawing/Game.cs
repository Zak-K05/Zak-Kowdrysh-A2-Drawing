// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        private Color[] circleColors = { Color.Yellow };

      
        public void Setup()
        {
            Window.SetTitle("Starry Night Sky");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            // Draw Yellow Stars
            Draw.FillColor = Color.Yellow;
        }
    }
}
