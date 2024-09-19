using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Figure
    {
        protected List<Point> pList;  //protected - Et muutuv pList oleks pärijatel nähtav
        //Meetod joonistab kõik figuuripunktid (Метод рисует все точки фигуры)
        public virtual void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) 
                    return true;
            }
            return false;
        }
    }
}
