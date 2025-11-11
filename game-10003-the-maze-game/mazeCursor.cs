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
        // Cursor position and size
        Vector2 pos;
        Vector2 size;

        // Set up for cursor position and size
        public mazeCursor(Vector2 pos, Vector2 size)
        {
            this.pos = pos;
            this.size = size;

        }

        public void Update(mazeHitbox[] mazeWall)
        {
            playerDraw();
            playerMovement();
            collisionProcess(mazeWall); // Checks for collisions with maze hitboxes
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

        // Collision detection
        public void collisionProcess(mazeHitbox[] mazeWall)
        {
            for(int mazebox = 0; mazebox < mazeWall.Length; mazebox++)
            {
                mazeHitbox hitbox = mazeWall[mazebox];

                // Hitbox collision boundaries
                float hitboxTop = hitbox.pos.Y;
                float hitboxBottom = hitbox.pos.Y + hitbox.size.Y;
                float hitboxLeft = hitbox.pos.X;
                float hitboxRight = hitbox.pos.X + hitbox.size.X;

                // Player collision boundaries
                float playerTop = pos.Y - size.Y / 2;
                float playerBottom = pos.Y + size.Y / 2;
                float playerLeft = pos.X - size.X / 2;
                float playerRight = pos.X + size.X / 2;

                // Checks if they touch each other
                bool isColliding = playerRight > hitboxLeft && playerLeft < hitboxRight && playerBottom > hitboxTop && playerTop < hitboxBottom;

                if (isColliding)
                {
                    // If player touches the wall
                    if (hitbox.collideType)
                    {
                        Game.onCollide = true;
                    }
                    // If player touches the goal
                    if(hitbox.collideType == false)
                    {
                        Game.level++;
                    }
                }

            }
        }
    }
}
