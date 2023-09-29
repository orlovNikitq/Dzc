using System;
using System.Collections.Specialized;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // num 1
            /*
                         Console.WriteLine("Введите число от 1 до 100");
                         int number = Convert.ToInt32(Console.ReadLine());
                             if (number <= 100 && number >= 1)
                             {
                                 if (number % 3 == 0 && number % 5 == 0)
                                 {
                                     Console.WriteLine("Fizz Buzz");
                                 }
                                 else if (number % 5 == 0)
                                 {
                                     Console.WriteLine("Buzz");
                                 }
                                 else if (number % 3 == 0)
                                 {
                                     Console.WriteLine("Fizz");
                                 }
                                 else
                                 {
                                Console.WriteLine(number);      
                                 }

                             }
                             else
                             {
                                 Console.WriteLine("Число больше 100 или меньше 1");
                             }
            */

            //num 2
            /*            
                        Console.WriteLine("Введите число");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите процент");
                        int percent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(number * percent / 100);
            */

            //num 3
            /*
            Console.WriteLine("Введите 4 цифры");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
*/

            //num 4
            /*
                        Console.WriteLine("Введите шестизначное число:");
                        string numStr = Console.ReadLine();
                        char[] array = numStr.ToCharArray();

                        if (Convert.ToInt32(numStr) > 999999 || Convert.ToInt32(numStr) < 100000) Console.WriteLine("Попробуйте еще раз");
                        else
                        {
                            Console.WriteLine("Какие цифры поменять местами:");
                            int number1 = Convert.ToInt32(Console.ReadLine());
                            int number2 = Convert.ToInt32(Console.ReadLine());

                            char temp = array[number1 - 1];
                            array[number1-1] = array[number2-1];
                            array[number2-1] = temp;

                            string resultStr = new string(array);
                            Console.WriteLine("Результат: " + resultStr);
                        }
            */

            //num 5
            /*
            Console.Write("Введите дату(dd.mm.yy)");
            var date = Console.ReadLine();
            var dateParsed = Convert.ToDateTime(date);
            Console.WriteLine(dateParsed.DayOfWeek);
*/

            //num 6
            /*
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Перевести из Фаренгейта в Цельсий");
            Console.WriteLine("2. Перевести из Цельсия в Фаренгейт");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number == 1)
            {
                Console.WriteLine("Введите F:");
                int fahrenheit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((fahrenheit - 32) / 1.8);
            }
            else if(number == 2) {
                Console.WriteLine("Введите C:");
                int celsius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(celsius * 1.8 + 32);
            }
            else
            {
                Console.WriteLine("Ошибка: Выберите 1 или 2");
            }
*/

            //num 7
            /*
            Console.WriteLine("Введите начало диапазона");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int end = Convert.ToInt32(Console.ReadLine());
            if(start > end)
            {
                (start, end) = (end, start);
            }
            for(int i = start; i <= end; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
*/

        }
    }
}