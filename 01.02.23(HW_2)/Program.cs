using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02._23_HW_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            Console.WriteLine("Задача 1");
            Console.Write("Введите число от 1 до 100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 100 || num < 1)
            {
                Console.WriteLine("Введено неверное число\n");
                return;
            }
            if (num % 3 == 0)
                Console.Write("Fizz ");
            if (num % 5 == 0)
                Console.Write("Buzz ");
            if (num % 3 != 0 && num % 5 != 0)
                Console.Write($"{num}");
            Console.WriteLine();
            #endregion

            #region Задача 2
            Console.WriteLine("\nЗадача 2");
            Console.WriteLine("Введите число: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите % который ищите: ");
            int perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ответ = {num_2 * perc / 100}");
            #endregion

            #region Задача 3
            Console.WriteLine("\nЗадача 3");
            Console.WriteLine("Введите 1 число: ");
            string num_3_1 = Console.ReadLine();
            Console.WriteLine("Введите 2 число: ");
            string num_3_2 = Console.ReadLine();
            Console.WriteLine("Введите 3 число: ");
            string num_3_3 = Console.ReadLine();
            Console.WriteLine("Введите 4 число: ");
            string num_3_4 = Console.ReadLine();
            int num_3 = Convert.ToInt32(num_3_1 + num_3_2 + num_3_3 + num_3_4);
            Console.WriteLine($"Целое число: {num_3}");
            #endregion

            #region Задача 4
            Console.WriteLine("\nЗадача 4");
            Console.WriteLine("Введите шестизначное число: ");
            string num_4 = Console.ReadLine();
            if (num_4.Length != 6)
            {
                Console.WriteLine("Введено неверное число\n");
                return;
            }
            Console.WriteLine("Введите 1 число: ");
            int num_4_1 = Convert.ToInt32(Console.ReadLine());
            num_4_1--;
            Console.WriteLine("Введите 2 число: ");
            int num_4_2 = Convert.ToInt32(Console.ReadLine());
            num_4_2--;
            char buf2_4 = num_4[num_4_2];
            char buf1_4 = num_4[num_4_1];
            num_4 = num_4.Remove(num_4_1, 1).Insert(num_4_1, buf2_4.ToString());
            num_4 = num_4.Remove(num_4_2, 1).Insert(num_4_2, buf1_4.ToString());
            Console.WriteLine($"Результат: {num_4}");
            #endregion

            #region Задача 5
            Console.WriteLine("\nЗадача 5");
            Console.Write("Введите дату в формате DD.MM.YY: ");
            string date_5 = Console.ReadLine();
            string date_d = date_5[0].ToString();
            date_d += date_5[1];
            string date_m = date_5[3].ToString();
            date_m += date_5[4];
            int num_d = Convert.ToInt32((date_d));
            int num_m = Convert.ToInt32((date_m));
            if ((num_m >= 1 && num_m <= 2) || num_m == 12)
                Console.Write("Winter ");
            else if (num_m >= 3 && num_m <= 5)
                Console.Write("Spring ");
            else if (num_m >= 6 && num_m <= 8)
                Console.Write("Summer ");
            else if (num_m >= 9 && num_m <= 11)
                Console.Write("Autumn ");
            int buf_5 = num_d % 7;
            switch (buf_5)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

            }
            #endregion

            #region Задача 6
            Console.WriteLine("\nЗадача 6");
            Console.Write("С - Цельсий, F - Фаренгейт: ");
            string type_6 = Console.ReadLine();
            if (type_6 != "F" && type_6 != "C")
            {
                Console.WriteLine("Введено неверное значение\n");
                return;
            }
            Console.WriteLine("Введите кол-во градусов");
            double num_6 = Convert.ToDouble(Console.ReadLine());
            if (type_6 == "F")
            {
                Console.Write($"F = {num_6}° ");
                double ces = (num_6 - 32) * 5 / 9;
                Console.Write($"C = {ces}° ");
            }
            else
            {
                Console.Write($"C = {num_6}° ");
                double far = (num_6 * 9 / 5) + 32;
                Console.Write($"F = {far}° ");
            }
            Console.WriteLine();
            #endregion

            #region Задача 7
            Console.WriteLine("\nЗадача 7");
            Console.Write("Введите 1 число: ");
            int min_7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int max_7 = Convert.ToInt32(Console.ReadLine());
            if(min_7 > max_7)
            {
                int buf = min_7;
                min_7 = max_7;
                max_7 = buf;
            }
            Console.Write("Все четные числа введенного диапазона: ");
            for(int i = min_7; i <= max_7; i+=2)
            {
                if (i % 2 != 0)
                    i++;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
