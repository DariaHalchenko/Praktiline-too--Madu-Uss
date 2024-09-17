using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
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

        public Point CreateFood()
        {
            int x = Random.Next(2, mapWidht - 2);
            int y = Random.Next(1, mapHeight - 2);
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
