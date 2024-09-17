using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too__Madu_Uss
{
    public class Level_2
    {
        private Walls walls;
        private Snake snake;
        private FoodCreator foodCreator;
        private List<Point> foodItems;
        private kiiruse_muutus kiiruseMuutus;
        private mängija_punktid MängijaPunktid;   
        private Madu_värv madu_Värv;
        public void Level_2_Play()
        {
            Walls walls = new Walls(50, 25);
            walls.Draw();

            //скорость
            kiiruse_muutus kiiruseMuutus = new kiiruse_muutus(30);

            //Создание змейки
            Point p = new Point(4, 5, 'o');
            Snake snake = new Snake(p, 4, Direction.RIGHT, kiiruseMuutus);
            snake.Drow();

            // Создание нескольких типов еды 
            char[] food_Symbols = { '¤', '&', '♥', '+', '-' };
            FoodCreator foodCreator = new FoodCreator(80, 25, food_Symbols);
            List<Point> foodItems = foodCreator.food_for_snake(5);

            mängija_punktid MängijaPunktid = new mängija_punktid();

            Madu_värv madu_Värv = new Madu_värv();

            // Отрисовывка еды
            foreach (var food in foodItems)
            {
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
                        madu_Värv.Värvi_muuta(foodItems[i].symbol);

                        MängijaPunktid.lisaPunkte(foodItems[i].symbol);
                        MängijaPunktid.Skoori_kuva();

                        // Проверка, какой символ съела змейка: + или -
                        if (foodItems[i].symbol == '+')
                        {
                            kiiruseMuutus.SuurendaKiirus(); // Увеличиваем скорость
                        }
                        else if (foodItems[i].symbol == '-')
                        {
                            kiiruseMuutus.KiirustVähendada(); // Уменьшаем скорость
                        }

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
