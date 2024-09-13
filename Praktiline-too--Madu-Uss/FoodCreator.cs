﻿using System;
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
        private char sym;

        Random Random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = Random.Next( 2, mapWidht - 2 ); 
            int y = Random.Next( 2, mapHeight - 2 );
            return new Point(x, y, sym);
        }
    }
}
