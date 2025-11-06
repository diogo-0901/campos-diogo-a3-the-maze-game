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

        public void Update()
        {
            playerDraw();
            playerMovement();
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

        public void collisionProcess()
        {

        }
    }
}
