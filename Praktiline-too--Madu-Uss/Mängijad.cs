﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    internal class Mängijad
    {
        private string Nimi;
        private mängija_punktid kontrollida;
        
        public Mängijad(string nimi, mängija_punktid kontrollida)
        {
            this.Nimi = nimi;
        }
        
        public void Salvesta_faili()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"..\..\..\Rekordid.txt", true);
                sw.WriteLine($"{Nimi}: {kontrollida.Saada_tulemus} points");
                sw.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Fail ei leitud");
            }
        }

        public void Naitab_faili()
        {
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\Rekordid.txt");
                string lines = sr.ReadToEnd();
                Console.WriteLine(lines);
                sr.Close();

                List<string> result = new List<string>();
                foreach (var rida in File.ReadAllLines(@"..\..\..\Rekordid.txt"))
                {
                    result.Add(rida);
                }
                foreach (var rida in result)
                {
                    Console.WriteLine(rida);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
