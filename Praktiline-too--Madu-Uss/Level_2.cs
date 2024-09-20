using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_2 
    {
        public void Level_2_Play(string nimi)
        {
            Walls walls = new Walls(60, 25);
            walls.Draw();

            Sounds sounds = new Sounds("../../../");

            //kiirus (скорость)
            kiiruse_muutus kiiruseMuutus = new kiiruse_muutus(30);

            //Madu loomine (Создание змейки)
            Point p = new Point(4, 5, 'o');
            Snake snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            //Mitme toidutüübi loomine  (Создание нескольких типов еды) 
            char[] food_Symbols = { '¤', '&', '♥', '+', '-' };
            FoodCreator foodCreator = new FoodCreator(60, 25, food_Symbols);
            List<Point> foodItems = foodCreator.food_for_snake(5);

            mängija_punktid kontrollida = new mängija_punktid();

            Madu_värv madu_Värv = new Madu_värv();

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
                    sounds.PlayGameOver();
                    Thread.Sleep(1000);
                    Mängijad mängijad = new Mängijad();
                    mängijad.Salvesta_faili(nimi, kontrollida);
                    break;
                }

                for (int i = 0; i < foodItems.Count; i++)
                {
                    if (snake.Eat(foodItems[i]))
                    {

                        madu_Värv.Värvi_muuta(foodItems[i].symbol);

                        kontrollida.lisaPunkte(foodItems[i].symbol);
                        kontrollida.Skoori_kuva();
                        sounds.PlayEat();

                        //Kontrolli, mis sümboli madu ära sõi: + või - (Проверка, какой символ съела змейка: + или -)
                        if (foodItems[i].symbol == '+')
                        {
                            kiiruseMuutus.SuurendaKiirus(); //Suurendame kiirust (Увеличиваем скорость)
                        }
                        else if (foodItems[i].symbol == '-')
                        {
                            kiiruseMuutus.KiirustVähendada(); //Vähendame kiirust (Уменьшаем скорость)
                        }

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
            Console.SetCursorPosition(1, 2);
        }
    }
}
