using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_3
    { 
        public void Level_3_Play(string nimi)
        {
            Walls walls = new Walls(35, 20);
            walls.Draw();

            //скорость
            kiiruse_muutus kiiruseMuutus = new kiiruse_muutus(3);

            //Создание змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            // Создание нескольких типов еды 
            char[] food_Symbols = { '♦','♣', '♥', '€' };
            FoodCreator foodCreator = new FoodCreator(35, 20, food_Symbols);
            List<Point> foodItems = foodCreator.food_for_snake(4);

            mängija_punktid kontrollida = new mängija_punktid();

            // Отрисовывка еды
            foreach (var food in foodItems)
            {
                food.Draw();
            }

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Mängijad mängijad = new Mängijad();
                    mängijad.Salvesta_faili(nimi, kontrollida);
                    break;
                }

                for (int i = 0; i < foodItems.Count; i++)
                {
                    if (snake.Eat(foodItems[i]))
                    {
                        kontrollida.lisaPunkte(foodItems[i].symbol);
                        kontrollida.Skoori_kuva();

                        // Если еда съедена, создаём её на новом месте
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
            Console.SetCursorPosition(1, 2);
        }
    }
}
