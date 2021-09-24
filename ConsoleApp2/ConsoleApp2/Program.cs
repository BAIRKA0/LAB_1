using System;

namespace ConsoleApp2
{
    public class Logic
    {
        public static string cut(int a,int b)
        {
            string outMessage = "";
            int i=0;
            for (int t = 0; t != 1; i++)
            {
                if (a > b)                  //Вычисляется наименьшая сторона 
                {
                    Console.WriteLine("Разрезан на квадрат размером {0}", b);
                    a = a - b;                          //Отрезается от прямоугольника квадрат размером наименьшей стороны прямоугольника
                    Console.WriteLine("Прямоугольник размером: {0} {1}", a, b);
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine("Разрезан на квадрат размером {0}", a);
                        b = b - a;                      //Отрезается от прямоугольника квадрат размером наименьшей стороны прямоугольника
                        Console.WriteLine("Прямоугольник размером: {0} {1}", a, b);
                    }
                    else
                    {
                        if (a == b)      //Если прямоугольник это квадрат то отрезается весь прямоугольник
                        {
                            Console.WriteLine("Разрезан на квадрат размером {0}", a);
                            t = 1;                          //Конец цикла
                        }
                    }
                }
            }
            outMessage = "Количество квадратов: " + i;
            return outMessage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите длину прямоугольника");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Введите ширину прямоугольника");
                b = Convert.ToInt32(Console.ReadLine());
                if (b > 0)
                {
                    var outMessage = Logic.cut(a, b);
                    Console.WriteLine(outMessage);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Введено неправильное значение");
                }
            }
            else
            {
                Console.WriteLine("Введено неправильное значение");
            }
        }
    }
}
