// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    /// Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Positions of the shooting stars
        private float[] starX = new float[20];
        private float[] starY = new float[20];

        // Number of stars currently created
        private int starCount = 0;

        // Speed of the shooting stars
        private const float starSpeed = 100;

        public void Setup()
        {
            Window.SetTitle("Starry Night Sky");
            Window.SetSize(400, 400);
        }

        /// <summary>
        /// Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Draw the background
            Window.ClearBackground(Color.DarkGray);

            // Create a star when the mouse is clicked
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                if (starCount < 500)
                {
                    starX[starCount] = Input.GetMouseX();
                    starY[starCount] = Input.GetMouseY();

                    starCount++;
                }
            }

            // Draw and move every shooting star
            for (int i = 0; i < starCount; i++)
            {
                // Star trail
                Draw.FillColor = Color.Gray;
                Draw.Rectangle(starX[i] + 5, starY[i] - 2, 35, 4);

                // Main star
                Draw.FillColor = Color.Yellow;
                Draw.Circle(starX[i], starY[i], 8);

                // Bright center
                Draw.FillColor = Color.White;
                Draw.Circle(starX[i], starY[i], 3);

                // Move diagonally across the sky
                starX[i] -= starSpeed * Time.DeltaTime;
                starY[i] += starSpeed * Time.DeltaTime;
            }
        }
    }
}
