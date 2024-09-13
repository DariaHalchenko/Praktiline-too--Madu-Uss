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
        public virtual void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
