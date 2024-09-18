using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    internal class Mängijad
    {
        private string _failiTee = @"..\..\..\Rekordid.txt";

        public Mängijad() { }

        public void Salvesta_faili(string Nimi, mängija_punktid punktid)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_failiTee, true))
                {
                    sw.WriteLine($"{Nimi}: {punktid.Saada_tulemus()} points");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Naitab_faili()
        {
            try
            {
                StreamReader sr = new StreamReader(_failiTee);
                string lines = sr.ReadToEnd();
                Console.WriteLine(lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
