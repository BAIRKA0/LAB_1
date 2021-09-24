using System;

namespace ConsoleApp1
{
    public class Logic // класс где будем хранить логику вычисления рублей и копеек
    {
        public static string count(int n)
        {
            string outMessage = "";
            int r = n / 100;       //Переменная содержащая кол-во рублей
            int k = n % 100;       //Переменная содержащая кол-во копеек без рублей
            if (r != 0 || k != 0)
            {
                if (r != 0)
                {
                    if (((r % 10) >= 5 && (r % 10) <= 9) || (r % 10) == 0 || (r >= 11 && r <= 20))
                    {
                        outMessage = r+" рублей ";  //Вывод кол-во рублей
                    }
                    else
                    {
                        if ((r % 10) >= 2 && (r % 10) <= 4)
                        {
                            outMessage = r + " рубля ";  //Вывод кол-во рублей
                        }
                        else
                        {
                            if (r % 10 == 1)
                            {
                                outMessage = r + " рубль ";  //Вывод кол-во рублей
                            }

                        }
                    }
                }
                if (k == 0)
                {
                    outMessage = outMessage+" ровно";  //Если кол-во рублей равное то вывод "ровно"
                }
                else
                {

                    if (k % 10 == 0 || (k >= 11 && k <= 20))
                    {
                        outMessage = outMessage + k+" копеек ";  //Вывод кол-во копеек
                    }
                    else
                    {
                        if (k % 10 == 1)
                        {
                            outMessage = outMessage + k + " копейка ";  //Вывод кол-во копеек
                        }
                        else
                        {
                            if (k % 10 >= 2 && k % 10 <= 4)
                            {
                                outMessage = outMessage + k + " копейки ";  //Вывод кол-во копеек
                            }
                            else
                            {
                                if (k % 10 >= 5 && k % 10 <= 9)
                                {
                                    outMessage = outMessage + k + " копеек ";  //Вывод кол-во копеек
                                }
                            }
                        }
                    }
                }
            }
            return outMessage;

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            int n;                 //Переменная содержащая количество копеек
            Console.WriteLine("Введите стоимость товара в копейках(от 1 до 9999)");
            n = Convert.ToInt32(Console.ReadLine());       //Вводит общее количество копеек
            var outMessage = "";
            if (n >= 1 && n <= 9999)
            {
                outMessage = Logic.count(n);    //вычисляетя кол-во рублей и копеек
            }
            else
            {
                outMessage = "Введено неправильное значение";
            }
            Console.WriteLine(outMessage);      //Выводится кол-во рублей и копеек
            Console.ReadKey();                  //Ждет нажатия любой клавиши, чтобы программа не закрывалась после выполнения
        }
    }
}
