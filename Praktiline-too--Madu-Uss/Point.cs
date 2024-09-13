using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }
        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        internal void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }
    }
}
