using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //Klass on kasutusel seintega mao kokkupõrgete loomiseks ja kontrollimiseks.
    //Класс используется для создания и проверки столкновений змеи со стенами.
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            //esitavad mängimiseks seinu (представляют стены для игры)
            //joonistusraamid
            HorizontalLine upLine = new HorizontalLine(1, mapWidth - 2, 3, '=');
            HorizontalLine downLine = new HorizontalLine(1, mapWidth - 2, mapHeight - 1, '=');
            VerticalLine leftLine = new VerticalLine(3, mapHeight - 1, 0, '|');
            VerticalLine rightLine = new VerticalLine(3, mapHeight - 1, mapWidth - 1, '|');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        //проверяет, произошло ли столкновение змеи со стенами
        //kontrollib, kas mao kokkupõrge seintega on toimunud
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        //joonistab seinad maha (отрисовывает стены)
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}

