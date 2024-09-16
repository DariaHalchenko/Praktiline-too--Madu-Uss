using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
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
        }
    }
}