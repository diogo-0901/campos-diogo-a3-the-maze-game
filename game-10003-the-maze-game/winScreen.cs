using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class winScreen
    {
        Vector2 pos;
        Vector2 velocity;
        Texture2D winScreenTexture = Graphics.LoadTexture("Assets/winScreen.jpg");
        Vector2 collisionRect = new Vector2(800, 600);
        public void Setup()
        {
            pos = new Vector2(400, 300);

            velocity = Random.Vector2() * 1000.0f;
        }

        public void Update()
        {
            shakeWinScreen();
            DrawWinScreen();
            processCollision();
        }

        void DrawWinScreen()
        {
            Vector2 origin = new Vector2(winScreenTexture.Width / 2f, winScreenTexture.Height / 2f);
            Graphics.Draw(winScreenTexture, pos - origin);
        }

        void shakeWinScreen()
        {
            pos += velocity * Time.DeltaTime;
        }
        void processCollision()
        {
            float halfX = collisionRect.X / 2f;
            float halfY = collisionRect.Y / 2f;
            float leftEdge = pos.X - halfX;
            float rightEdge = pos.X + halfX;
            float topEdge = pos.Y - halfY;
            float bottomEdge = pos.Y + halfY;

            if (leftEdge < 0 - 10)
            {
                velocity.X *= -1;
                pos.X = 0 + halfX;
            }
            if (rightEdge > Window.Width + 10)
            {
                velocity.X *= -1;
                pos.X = Window.Width - halfX;
            }
            if (topEdge < 0 - 10)
            {
                velocity.Y *= -1;
                pos.Y = 0 + halfY;
            }
            if (bottomEdge > Window.Height + 10)
            {
                velocity.Y *= -1;
                pos.Y = Window.Height - halfY;
            }

        }
    }
}
