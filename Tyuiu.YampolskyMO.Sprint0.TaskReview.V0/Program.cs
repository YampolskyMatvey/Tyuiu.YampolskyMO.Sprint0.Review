using System;
using Tyuiu.YampolskyMO.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.YampolskyMO.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Sprint Review                                                      *");
            Console.WriteLine("* Задание TaskReview                                                      *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский Матвей Олегович | ИИПб-26-1                        *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (x + y + z) * 5         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Z:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            int res = ds.Calc(x, y, z);
            Console.WriteLine("Результат выражения (x + y + z) * 5 = " + res);

            Console.ReadKey();
        }
    }
}