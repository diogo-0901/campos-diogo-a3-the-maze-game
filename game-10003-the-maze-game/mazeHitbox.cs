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
        public bool collideType;

        Color color;

        // Assigns options to edit position, size, whether it's a wall or goal, and colour
        public mazeHitbox(Vector2 pos, Vector2 size, bool collideType, Color color)
        {
            this.pos = pos;
            this.size = size;
            this.collideType = collideType;
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
