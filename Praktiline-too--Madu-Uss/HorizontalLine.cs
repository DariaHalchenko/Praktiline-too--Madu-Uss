using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    class HorizontalLine : Figure //Päritakse figuurilt
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        //цвет рамки
        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            base.Drow();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
