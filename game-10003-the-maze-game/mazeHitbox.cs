using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class mazeHitbox
    {
        public Vector2 pos;
        public Vector2 size;
        public bool isBad;

        Color color;

        public mazeHitbox(Vector2 pos, Vector2 size, bool isBad, Color color)
        {
            this.pos = pos;
            this.size = size;
            this.isBad = isBad;
            this.color = color;
        }

        public void Update()
        {
            hitboxDraw();
        }

        public void hitboxDraw()
        {
            Draw.LineSize = 0;
            Draw.FillColor = color;
            Draw.Rectangle(pos, size);
        }
    }
}
