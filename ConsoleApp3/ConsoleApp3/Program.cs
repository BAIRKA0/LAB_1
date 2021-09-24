using System;

namespace ConsoleApp3
{
    public class Logic
    {
        public static string Sum(string s)
        {
            string outMessage = "";
            int sum = 0, d1 = 0;                //Переменные содержащие информацию о сумме и переменной
            int i = 0;
            for (; s[i] != '+' && s[i] != '-'; i++)                     //Первая переменная становится суммой
            {
                sum = sum * 10 + Convert.ToInt32(s[i]) - 48;
            }
            for (; i < s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '-')
                {
                    i++;
                    for (int j = i; s[j] != '+' && s[j] != '-'; j++)    //Вычисляется вторая переменная
                    {
                        d1 = d1 * 10 + Convert.ToInt32(s[j]) - 48;
                        if ((j + 1) == s.Length)
                        {
                            break;
                        }
                    }
                    if (s[i - 1] == '+')                                //Если + то прибавляется эта переменная к сумме
                    {
                        sum = sum + d1;
                        d1 = 0;
                    }
                    if (s[i - 1] == '-')                                //Если - то отнимается эта переменная от суммы
                    {
                        sum = sum - d1;         
                        d1 = 0;
                    }
                }
            }
            outMessage = "Сумма = " + sum;
            return outMessage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение");
            string s = Console.ReadLine();
            int t = 0, z = 0;
            if (s[s.Length - 1] == '+' || s[s.Length - 1] == '-')           //если последний символ + или - то выводит ошибку
            {
                z = 1;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ' || s[i] != '+' || s[i] != '-' || s[i] != '1' || s[i] != '2' || s[i] != '3' || s[i] != '4' || s[i] != '5' || s[i] != '6' || s[i] != '7' || s[i] != '8' || s[i] != '9')    //Проверяет правильно ли введено выражение
                    {
                        t = 1;
                    }
                    if ((s[i] == '+' || s[i] == '-') && (s[i + 1] == '+' || s[i + 1] == '-') && i < (s.Length - 1))         //Если два символа подряд то выводт ошибку
                    {
                        z = 1;
                    }

                }
            }
            var outMessage = "";
            if (t == 1 && z==0 && (s[0] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != '+'))   //Если правильно 
            {
                outMessage = Logic.Sum(s);
            }
            else
            {
                outMessage = "Вы ввели не правильное выражение";                                                //если не правильно
            }
            Console.WriteLine(outMessage);
            Console.ReadKey();

        }
    }
}
