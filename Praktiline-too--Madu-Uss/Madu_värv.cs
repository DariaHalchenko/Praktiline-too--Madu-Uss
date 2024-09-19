using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //klass on mõeldud värvi muutmiseks vastavalt sümbolile(предназначен для изменения цвета в зависимости от символа)
    class Madu_värv
    {
        public void Värvi_muuta(char värv)
        {
            if (värv == '+')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (värv == '-')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (värv == '¤')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (värv == '&')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (värv == '♥')
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (värv == '#')
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (värv == '%')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
        }
    }
}