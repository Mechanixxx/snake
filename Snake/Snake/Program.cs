﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize( 80, 25 );

            //Рамка
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //ТОчки
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();






        }
        
    }
}
