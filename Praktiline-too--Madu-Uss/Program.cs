using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Praktiline_too__Madu_Uss
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);

            Console.Clear();
            Console.WriteLine("Vali tasand:  (1 - Level 1, 2 - Level 2)");
            Console.Write("Sisesta tasemenumber: ");

            int valitud_tase = int.Parse(Console.ReadLine());;

            if (valitud_tase == 1 || valitud_tase == 2)
            {
                // Запуск выбранного уровня
                if (valitud_tase == 1)
                {
                    Level_1 level_1 = new Level_1();
                    level_1.Level_1_Play();
                }
                else if (valitud_tase == 2)
                {
                    Level_2 level_2 = new Level_2();
                    level_2.Level_2_Play();
                }
            }
            else
            {
                Console.WriteLine("Viga!");
            }
        }
    }
}
