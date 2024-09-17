using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //Mängija punktid класс, который будет  хранить и обновлять очки 
    class mängija_punktid
    {
        private int kontrollida;
        public mängija_punktid()
        {
            kontrollida = 0;
        }
        //увеличивает очки  
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
                kontrollida -= 10;
            }
            else if (FoodSymbols == '%')
            {
                kontrollida *= 2;
            }
            else if (FoodSymbols == '€')
            {
                kontrollida += 10;
            }
            else if (FoodSymbols == '♦')
            {
                kontrollida -= 5;
            }
            else if (FoodSymbols == '♣')
            {
                kontrollida *= 3;
            }
        }
        public void Skoori_kuva()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Mängija tulemus: " + kontrollida);
        }
        public int Saada_tulemus()
        {
            return kontrollida;
        }
    }
}