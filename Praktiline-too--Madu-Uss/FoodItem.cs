using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //FoodItem klass mõjutada madude kiirust vastavalt sümbolile (- ja +)
    //класс воздействовать на скорость змей в соответствии с символом (- и +)
    class FoodItem
    {
        private char symbol;

        public FoodItem(char symbol)
        {
            this.symbol = symbol;
        }

        public bool Kiiruse_Suurendamise_Symbol()
        {
            return symbol == '+';
        }

        public bool Kiiruse_Vähendamise_Symbol()
        {
            return symbol == '-';
        }
    }
}