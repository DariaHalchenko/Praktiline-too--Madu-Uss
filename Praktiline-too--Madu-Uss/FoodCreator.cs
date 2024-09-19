using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    //Klass vastutab maotoidu loomise eest (Класс отвечает за создание змеиного питания)
    class FoodCreator
    {
        private int mapWidht;
        private int mapHeight;
        private char[] foodSymbols;

        Random Random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char[] food_Symbols)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.foodSymbols = food_Symbols;
        }
        //juhukoordinaadid välja piires ja massiivist juhuslikud sümbolid
        //случайные координаты в пределах поля и случайные символом из массива
        public Point CreateFood()
        {
            int x = Random.Next(2, mapWidht - 2);
            int y = Random.Next(4, mapHeight - 2);
            char foodSymbol = foodSymbols[Random.Next(foodSymbols.Length)];
            return new Point(x, y, foodSymbol);
        }

        public List<Point> food_for_snake(int count)
        {
            List<Point> foodItems = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                foodItems.Add(CreateFood());
            }
            return foodItems;
        }
    }
}
