using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class mazeCursor
    {
        Vector2 pos;
        Vector2 size;
        public mazeCursor(Vector2 pos, Vector2 size)
        {
            this.pos = pos;
            this.size = size;
        }

        public void Update(mazeHitbox[] mazeWall)
        {
            playerDraw();
            playerMovement();
            collisionProcess(mazeWall);
        }

        public void playerDraw()
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.Blue;
            Draw.Rectangle(pos - size / 2, size);

        }

        public void playerMovement()
        {
            pos = Input.GetMousePosition();
        }

        public void collisionProcess(mazeHitbox[] mazeWall)
        {
            for(int mazebox = 0; mazebox < mazeWall.Length; mazebox++)
            {
                mazeHitbox hitbox = mazeWall[mazebox];
                float hitboxTop = hitbox.pos.Y;
                float hitboxBottom = hitbox.pos.Y + hitbox.size.Y;
                float hitboxLeft = hitbox.pos.X;
                float hitboxRight = hitbox.pos.X + hitbox.size.X;

                float playerTop = pos.Y - size.Y / 2;
                float playerBottom = pos.Y + size.Y / 2;
                float playerLeft = pos.X - size.X / 2;
                float playerRight = pos.X + size.X / 2;


                bool isColliding = playerRight > hitboxLeft && playerLeft < hitboxRight && playerBottom > hitboxTop && playerTop < hitboxBottom;

                if (isColliding)
                {
                    if (hitbox.isBad)
                    {
                        //Game.titleScreen = true;
                        Console.WriteLine("its a bad box");
                    }
                    if(hitbox.isBad == false)
                    {
                        //Game.winScreen = true;
                        Console.WriteLine("its a good box");
                    }
                }

            }
        }
    }
}
