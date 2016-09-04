using System;
using System.Drawing;
using ListReflection;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = ListFactory.CreateList<Point>();

            for (var i = 0; i < 5; i++)
            {
                var point = new Point(i, 2 * i);
                list.AppendItem(point);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}