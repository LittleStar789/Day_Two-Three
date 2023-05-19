using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            int job_number = Convert.ToInt32(Console.ReadLine());
            switch (job_number)
            {
                case 1:
                    Console.WriteLine("Задание 1.");
                    Console.WriteLine("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 0)
                    {
                        int plus = number + 5;
                        Console.WriteLine($"{number} + 5 = " + plus);
                    }
                    else if (number < 0)
                    {
                        int minus = number - 5;
                        Console.WriteLine($"{number} - 5 = " + minus);
                    }
                    break;

                case 2:
                    Console.WriteLine("Задание 2.");
                    Console.WriteLine("Введите число номер 1: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число номер 3: ");
                    int number3 = Convert.ToInt32(Console.ReadLine());

                    if (number1 > number2 && number1 > number3)
                    {
                        Console.WriteLine($"Число {number1} наибольшее из них");
                    }
                    else if (number2 > number1 && number2 > number3)
                    {
                        Console.WriteLine($"Число {number2} наибольшее из них");
                    }
                    else if (number3 > number1 && number3 > number2)
                    {
                        Console.WriteLine($"Число {number3} наибольшее из них");
                    }
                    break;

                case 3:
                    Console.WriteLine("Задание 3.");
                    Console.WriteLine("Введите число номер 1: ");
                    int number_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2: ");
                    int number_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число номер 3: ");
                    int number_3 = Convert.ToInt32(Console.ReadLine());

                    if (number_1 >= 0 && number_2 >= 0 && number_3 < 0)
                    {
                        int sum1 = number_1 + number_2;
                        Console.WriteLine("Сумма положительных чисел равна " + sum1);
                    }
                    else if (number_2 >= 0 && number_3 >= 0 && number_1 < 0)
                    {
                        int sum2 = number_2 + number_3;
                        Console.WriteLine("Сумма положительных чисел равна " + sum2);
                    }
                    else if (number_3 >= 0 && number_1 >= 0 && number_2 < 0)
                    {
                        int sum3 = number_3 + number_1;
                        Console.WriteLine("Сумма положительных чисел равна " + sum3);
                    }
                    else if (number_3 >= 0 && number_1 >= 0 && number_2 > 0)
                    {
                        int sum4 = number_3 + number_1 + number_2;
                        Console.WriteLine("Сумма положительных чисел равна " + sum4);
                    }
                    break;

                case 4:
                    Console.WriteLine("Задание 4.");
                    Console.WriteLine("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 10)
                    {
                        int doubling = num * 2;
                        Console.WriteLine($"{num} * 2 = " + doubling);
                    }
                    else if (num < 10)
                    {
                        Console.WriteLine("Число меньше 10");
                    }
                    else if (num < 10)
                    {
                        Console.WriteLine("Число меньше 10");
                    }
                    else if (num == 10)
                    {
                        Console.WriteLine("Число равно 10");
                    }
                    break;

                case 5:
                    Console.WriteLine("Задание 5.");
                    Console.WriteLine("Введите число от 1 до 7: ");
                    int ttt = Convert.ToInt32(Console.ReadLine());
                    switch (ttt)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;
                    }
                    break;

                case 6:
                    Console.WriteLine("Задание 6.");
                    int number_ = 200;
                    while (number_ % 17 != 0)
                    {
                        number_++;
                    }
                    Console.WriteLine("Минимальное число, большее 200 и кратное 17: " + number_);
                    break;

                case 7:
                    Console.WriteLine("Задание 7.");
                    double distance = 10;
                    int day = 1;
                    while (distance <= 20)
                    {
                        distance = distance * 0.05 + distance;
                        day++;
                    }
                    Console.WriteLine($"В {day}-й день пробежит 20 км.");
                    while (distance <= 100)
                    {
                        distance = distance * 0.05 + distance;
                        day++;
                    }
                    Console.WriteLine($"В {day}-й день пробежит 100 км.");
                    break;

                case 8:
                    Console.WriteLine("Задание 8.");
                    Console.WriteLine("Введите число для вычисления факториала: ");
                    int num8 = Convert.ToInt32(Console.ReadLine()); 

                    if (num8 == 0)
                    Console.WriteLine("Факториал числа 0 равен 1.");
                     else
                        {  
                        int factor = 1;
                        for (int i = 1; i <= num8; i++)
                        {
                            factor *= i;
                        }
                        Console.WriteLine($"Факториал числа {num8} равен {factor}");
                        }
                    break;

                case 9:
                    Console.WriteLine("Задание 9.");
                    Console.WriteLine("Введите натуральное число: ");
                    int natur_num = Convert.ToInt32(Console.ReadLine());
                    int divider = 2;
                    while (natur_num % divider != 0)
                    {
                        divider++;
                    }
                    Console.WriteLine($"Наименьший делитель числа {natur_num} = {divider}");
                    break;
            }
        }
    }
}
