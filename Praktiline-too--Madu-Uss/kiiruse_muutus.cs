using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Praktiline_too__Madu_Uss
{
    //Kiiruse_muutuse klass juhib madude liikumiskiirust mängus. 
    class kiiruse_muutus
    {
        private double kiirus;
        public kiiruse_muutus(double kiirus)
        {
            this.kiirus = kiirus;
        }

        // Увеличение скорости
        public void SuurendaKiirus()
        {
            kiirus = kiirus * 0.5;
        }

        // Уменьшение скорости
        public void KiirustVähendada()
        {
            kiirus = kiirus * 1.5;
        }
        public int Kiirus()
        {
            return (int)kiirus;
        }
    }
}
