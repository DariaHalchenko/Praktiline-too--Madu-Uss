using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_3
    {
        private Walls walls;
        private Snake snake;
        private FoodCreator foodCreator;
        private List<Point> foodItems;
        private kiiruse_muutus kiiruseMuutus;
        private mängija_punktid MängijaPunktid; 
        private List<Takistus_mängus> takistus_Mängus;
        public void Level_3_Play()
        {
            Walls walls = new Walls(65, 20);
            walls.Draw();

            //скорость
            kiiruse_muutus kiiruseMuutus = new kiiruse_muutus(30);

            //Создание змейки
            Point p = new Point(4, 5, 'o');
            Snake snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            // Создание нескольких типов еды 
            char[] food_Symbols = { '♦','♣', '♥', '€' };
            FoodCreator foodCreator = new FoodCreator(65, 20, food_Symbols);
            List<Point> foodItems = foodCreator.food_for_snake(4);

            mängija_punktid MängijaPunktid = new mängija_punktid();
            
            takistus_Mängus = Takistus_mängus.Genereerida_takistus_mängus(10, 65, 20);
            foreach (var obstacle in takistus_Mängus)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                obstacle.Draw();
                Console.ResetColor();
            } 


            // Отрисовывка еды
            foreach (var food in foodItems)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
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

                        // Если еда съедена, создаём её на новом месте
                        Point newFood = foodCreator.CreateFood();
                        foodItems[i] = newFood;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        newFood.Draw();
                        Console.ResetColor();
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
            Console.SetCursorPosition(1, 2);
        }
    }
}
