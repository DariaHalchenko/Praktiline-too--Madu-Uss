using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Takistus_mängus
    {
        public Point point;
        private char symbol;
        
        public Takistus_mängus(Point point, char symbol)
        {
            this.point = point;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write(symbol);
        }
        public void Genereerida_takistus_mängus(int number_takistus_mängus, int width, int height)
        {
            Random Random = new Random();
            List<Takistus_mängus> takistus_Mängus = new List<Takistus_mängus>();
    
            for (int i = 0; i < number_takistus_mängus; i++)
            {
                int x = Random.Next(1, 79); 
                int y = Random.Next(1, 24); 
                char symbol = '/'; 
                takistus_Mängus.Add(new Takistus_mängus(new Point(x, y, symbol), symbol));
            }
        }   
    }
}
