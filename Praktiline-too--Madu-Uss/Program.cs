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

            Console.WriteLine("Sisesta oma nimi: ");
            string nimi = Console.ReadLine(); 
            
            mängija_punktid kontrollida = new mängija_punktid();

            Sounds sound = new Sounds("../../../");
            sound.Play();

            Console.Clear();
            Console.WriteLine("Vali tasand:  (1 - Level 1/ 2 - Level 2/ 3 - Level 3)");
            Console.Write("Sisesta tasemenumber: ");

            int valitud_tase = int.Parse(Console.ReadLine());;

            if (valitud_tase == 1 || valitud_tase == 2 || valitud_tase == 3)
            {
                // Запуск выбранного уровня
                if (valitud_tase == 1)
                {
                    Level_1 level_1 = new Level_1();
                    level_1.Level_1_Play();
                    sound.PlayEat();
                }
                else if (valitud_tase == 2)
                {
                    Level_2 level_2 = new Level_2();
                    level_2.Level_2_Play();
                    sound.PlayEat();
                }
                else if (valitud_tase == 3)
                {
                    Level_3 level_3 = new Level_3();
                    level_3.Level_3_Play();
                    sound.PlayEat();
                }

                kontrollida.Skoori_kuva();

                Mängijad mängijad = new Mängijad(nimi, kontrollida);

                sound.PlayGameOver();
            }
            else
            {
                Console.WriteLine("Viga!");
            }
        }
    }
}
