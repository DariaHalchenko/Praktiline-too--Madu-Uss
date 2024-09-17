using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_1
    {
        private Walls walls;
        private Snake snake;
        private FoodCreator foodCreator;
        private List<Point> foodItems;
        private kiiruse_muutus kiiruseMuutus;
        private mängija_punktid MängijaPunktid;

        public void Level_1_Play()
        {
            // Уменьшенное поле 
            walls = new Walls(80, 25);
            walls.Draw();

            // Увеличенние начальной скорости
            kiiruseMuutus = new kiiruse_muutus(15);

            Point p = new Point(4, 5, 'O');
            snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            char[] food_Symbols = { '¤', '&', '♥', '#', '%' };
            foodCreator = new FoodCreator(80, 25, food_Symbols);
            foodItems = foodCreator.food_for_snake(5);

            MängijaPunktid = new mängija_punktid();

            // Отрисовываем еду
            foreach (var food in foodItems)
            {
                Console.ForegroundColor = ConsoleColor.White;
                food.Draw();
            }

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                for (int i = 0; i < foodItems.Count; i++)
                {
                    if (snake.Eat(foodItems[i]))
                    {
                        MängijaPunktid.lisaPunkte(foodItems[i].symbol);

                        MängijaPunktid.Skoori_kuva();

                        Point newFood = foodCreator.CreateFood();
                        foodItems[i] = newFood;
                        newFood.Draw();
                    }
                }

                snake.Move();
                Thread.Sleep(kiiruseMuutus.Kiirus() * 15);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            Console.SetCursorPosition(2, 1);
        }
    }
}