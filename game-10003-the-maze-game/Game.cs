// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        public bool onCollide = true;
        mazeCursor Cursor = new mazeCursor(new Vector2(10, 10), new Vector2(10, 10));
        mazeHitbox[] mazeWall = { 
        new mazeHitbox(new Vector2(0, 0), new Vector2(200, 490), true, Color.Black)
        };
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("The Maze Game");
            Window.SetSize(800, 600);
            Window.TargetFPS = 30;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);
            Cursor.Update();
            for (int i = 0; i < mazeWall.Length; i++)
            {
                mazeWall[i].Update();
            }
        }
    }

}
