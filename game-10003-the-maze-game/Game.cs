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
        mazeCursor Cursor = new mazeCursor(new Vector2(-1, -1), new Vector2(7, 7));
        mazeHitbox[] mazeWall = { 
        new mazeHitbox(new Vector2(0, 0), new Vector2(400, 220), true, Color.Black),
        new mazeHitbox(new Vector2(0, 220), new Vector2(100, 380), true, Color.Black),
        new mazeHitbox(new Vector2(100, 550), new Vector2(700, 50), true, Color.Black),
        new mazeHitbox(new Vector2(460, 0), new Vector2(800, 260), true, Color.Black),
        new mazeHitbox(new Vector2(700, 420), new Vector2(800, 180), true, Color.Black),
        new mazeHitbox(new Vector2(150, 260), new Vector2(800, 160), true, Color.Black),
        new mazeHitbox(new Vector2(100, 470), new Vector2(560, 40), true, Color.Black),


        new mazeHitbox(new Vector2(410, 230), new Vector2(30, 30), true, Color.Black),
        new mazeHitbox(new Vector2(440, 120), new Vector2(30, 140), true, Color.Black),
        new mazeHitbox(new Vector2(400, 180), new Vector2(30, 40), true, Color.Black),
        new mazeHitbox(new Vector2(410, 140), new Vector2(30, 30), true, Color.Black),
        new mazeHitbox(new Vector2(400, 120), new Vector2(30, 10), true, Color.Black),
        new mazeHitbox(new Vector2(400, 40), new Vector2(10, 80), true, Color.Black),
        new mazeHitbox(new Vector2(400, 0), new Vector2(60, 40), true, Color.Black),
        new mazeHitbox(new Vector2(410, 40), new Vector2(50, 80), true, Color.Red),


        };
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("The Maze Game");
            Window.SetSize(800, 600);
            Window.TargetFPS = 120;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);
            Cursor.Update(mazeWall);
            for (int i = 0; i < mazeWall.Length; i++)
            {
                mazeWall[i].Update();
            }
        }
    }

}
