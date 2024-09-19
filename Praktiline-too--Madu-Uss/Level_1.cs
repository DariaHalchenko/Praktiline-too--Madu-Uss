using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_1
    {
        public void Level_1_Play(string nimi)
        {
            //Vähendatud väli (Уменьшенное поле)
            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Suurenenud algkiirus (Увеличенние начальной скорости)
            kiiruse_muutus kiiruseMuutus = new kiiruse_muutus(15);

            //Madu loomine (Создание змейки)
            Point p = new Point(4, 5, 'O');
            Snake snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            //Mitme toidutüübi loomine  (Создание нескольких типов еды) 
            char[] food_Symbols = { '¤', '&', '♥', '#', '%' };
            FoodCreator foodCreator = new FoodCreator(80, 25, food_Symbols);
            List<Point> foodItems = foodCreator.food_for_snake(5);

            mängija_punktid kontrollida = new mängija_punktid();

            //Toidu joonistamine (Отрисовывка еды)
            foreach (var food in foodItems)
            {
                food.Draw();
            }
            //faili salvestamine (сохранение в файл)
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
                        //Kui toit on söödud, loome selle uude kohta (Если еда съедена, создаём её на новом месте)
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