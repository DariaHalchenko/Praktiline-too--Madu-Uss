using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Praktiline_too__Madu_Uss
{
    //klass, mis juhib madude käitumist mängus (класс, который управляет поведением змейки в игре)
    class Snake : Figure
    {
        public Direction direction; //hoiab suunda (хранит направление)
        public kiiruse_muutus kiiruseMuutus;

        //loob etteantud parameetritega madu (создаёт змею с заданными параметрами)
        public Snake(Point tail, int length, Direction _direction, kiiruse_muutus _kiiruseMuutus)
        {
            
            kiiruseMuutus = _kiiruseMuutus;
            direction = _direction;
            pList = new List<Point>();
            
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        //Madu liigutamise funktsioon (Функция перемещения змеи)
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        //Meetod, loob madu pea koopia ja nihutab selle ühele positsioonile, kui madu liigub
        //Метод, создает копию головы змеи и смещает ее на одну позицию, когда змея движется
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            pList.Last().symbol = 'o';
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        //Kontrollib, kas madu pea on tema enda sabale otsa sõitnud
        //Проверяет, врезалась ли голова змеи в её собственный хвост
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
        //Haldab madu liikumist vastavalt vajutatud klahvile
        //Управляет движением змеи в зависимости от нажатой клавиши
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
        //kui madu puutub kokku toiduga, siis suurendab ta pikkust
        //если змея сталкивается с едой, то увеличивает её длину
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
