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
        private int kiirus;
        private int minKiirus;
        private int maxKiirus;
        public kiiruse_muutus(int kiirus, int minKiirus, int maxKiirus)
        {
            this.kiirus = kiirus;
            this.minKiirus = minKiirus;
            this.maxKiirus = maxKiirus;
        }

        // Увеличение скорости
        public void SuurendaKiirus()
        {
            if (kiirus > minKiirus)
            {
                kiirus -= 15;
            }
        }

        // Уменьшение скорости
        public void KiirustVähendada()
        {
            if (kiirus < maxKiirus)
            {
                kiirus += 5;
            }
        }
        public int Kiirus()
        {
            return kiirus;
        }
    }
}
