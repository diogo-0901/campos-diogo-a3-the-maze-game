// Include the namespaces (code libraries) you need below.
using Raylib_cs;
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
        Texture2D titleScreenGraphic = Graphics.LoadTexture("Assets/titleScreen.png");
        Texture2D playButton = Graphics.LoadTexture("Assets/playButton.png");
        Texture2D tempWin = Graphics.LoadTexture("Assets/winScreen.jpg");

        public static bool onCollide = false;
        public static int level = 0;
        mazeCursor Cursor = new mazeCursor(new Vector2(-1, -1), new Vector2(5, 5));
        mazeHitbox[] levelOne = {
        new mazeHitbox(new Vector2(0, 0), new Vector2(250, 600), true, Color.Black),
        new mazeHitbox(new Vector2(250, 0), new Vector2(550, 50), true, Color.Black),
        new mazeHitbox(new Vector2(720, 50), new Vector2(80, 40), true, Color.Black),
        new mazeHitbox(new Vector2(450, 90), new Vector2(350, 510), true, Color.Black),
        new mazeHitbox(new Vector2(250, 570), new Vector2(200, 30), true, Color.Black),
        new mazeHitbox(new Vector2(650, 50), new Vector2(70, 40), false, Color.Red), // Goal


        };
        mazeHitbox[] levelTwo = {
        new mazeHitbox(new Vector2(0, 0), new Vector2(100, 600), true, Color.Black),
        new mazeHitbox(new Vector2(100, 0), new Vector2(620, 50), true, Color.Black),
        new mazeHitbox(new Vector2(720, 0), new Vector2(80, 600), true, Color.Black),
        new mazeHitbox(new Vector2(150, 90), new Vector2(570, 80), true, Color.Black),
        new mazeHitbox(new Vector2(100, 220), new Vector2(570, 70), true, Color.Black),
        new mazeHitbox(new Vector2(150, 330), new Vector2(570, 80), true, Color.Black),
        new mazeHitbox(new Vector2(100, 450), new Vector2(510, 70), true, Color.Black),
        new mazeHitbox(new Vector2(100, 550), new Vector2(620, 50), true, Color.Black),
        new mazeHitbox(new Vector2(100, 520), new Vector2(60, 30), false, Color.Red) // Goal

        };
        mazeHitbox[] levelThree = { 
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
        new mazeHitbox(new Vector2(410, 40), new Vector2(50, 80), true, Color.Red), // Fake Goal
        new mazeHitbox(new Vector2(430, 170), new Vector2(10, 10), false, Color.Cyan) // Jumpscare


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
            // Title Screen
            if (level == 0 && onCollide == false)
            {
                Graphics.Draw(titleScreenGraphic, 0, 0);
                Graphics.Draw(playButton, 270, 490);
                if (Input.GetMouseX() > 270 && Input.GetMouseX() < 270 + 160 && Input.GetMouseY() > 490 && Input.GetMouseY() < 490 + 70 && Input.IsMouseButtonPressed(MouseInput.Left))
                {
                    level++;
                }
            }
            // Level 1
            if (level == 1 && onCollide == false)
            {
                for (int i = 0; i < levelOne.Length; i++)
                {
                    levelOne[i].Update();
                }
                Cursor.Update(levelOne);
            }

            // Level 2
            if (level == 2 && onCollide == false)
            {
                for (int i = 0; i < levelTwo.Length; i++)
                {
                    levelTwo[i].Update();
                }
                Cursor.Update(levelTwo);
            }

            // Level 3
            if (level == 3 && onCollide == false)
            {
                for (int i = 0; i < levelThree.Length; i++)
                {
                    levelThree[i].Update();
                }
                Cursor.Update(levelThree);
            }

            // PlayAudio
            if (level == 4 && onCollide == false)
            {
                for (int i = 0; i < levelThree.Length; i++)
                {
                    levelThree[i].Update();
                }
                Cursor.Update(levelThree);
                Audio.Play(Audio.LoadSound("Assets/winSound.mp3"));
            }

            // Win Screen
            if (level == 5)
            {
                Graphics.Draw(tempWin, 0, 0);
            }

            // Restart
            if (onCollide == true)
            {
                onCollide = false;
                level = 0;
            }

        }
    }

}
