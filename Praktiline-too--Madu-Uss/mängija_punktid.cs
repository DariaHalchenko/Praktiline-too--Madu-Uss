using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //klass, kes hoiab ja uuendab prille (класс, который будет  хранить и обновлять очки)
    class mängija_punktid
    {
        private int kontrollida;
        public mängija_punktid()
        {
            kontrollida = 0;
        }
        //suurendab arvet (увеличивает счет) 
        public void lisaPunkte(int FoodSymbols)
        {
            if (FoodSymbols == '+')
            {
                kontrollida += 1;
            }
            else if (FoodSymbols == '-')
            {
                kontrollida += 1;
            }
            else if (FoodSymbols == '¤')
            {
                kontrollida += 5;
            }
            else if (FoodSymbols == '&')
            {
                kontrollida += 2;
            }
            else if (FoodSymbols == '♥')
            {
                kontrollida += 4;
            }
            else if (FoodSymbols == '#')
            {
                kontrollida += 10;
            }
            else if (FoodSymbols == '%')
            {
                kontrollida = kontrollida * 2;
            }
            else if (FoodSymbols == '€')
            {
                kontrollida += 10;
            }
            else if (FoodSymbols == '♦')
            {
                kontrollida = kontrollida - 5;
            }
            else if (FoodSymbols == '♣')
            {
                kontrollida = kontrollida * 3;
            }
        }
        //kuvab arve (отображает счет)
        public void Skoori_kuva()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Mängija tulemus: " + kontrollida);
        }
        public int Saada_tulemus()
        {
            return kontrollida;
        }
    }
}