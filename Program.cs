using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace SuperCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int doing;
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В КАЛЬКУЛЯТОР!!!");
            Console.WriteLine(" ");
            Console.WriteLine("Нажмите клавишу ENTER, чтобы продолжить и увидеть меню выбора операций:");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Выберите операцию из меню для выполнения работы и введите номер, под которым она записана: ");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть одно число из другого");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое число на второе");
            Console.WriteLine("5. Возвести первое число в степень, которая вводится вторым числом");
            Console.WriteLine("6. Найти квадратный корень из введенного числа");
            Console.WriteLine("7. Найти один процент от введенного числа");
            Console.WriteLine("8. Найти факториал из введенного числа");
            Console.WriteLine("9. Выйти из программы и завершить работу с калькулятором");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            do
            { 
                doing = int.Parse(Console.ReadLine());
                if (doing == 9)
                {
                    Console.WriteLine("вы завершили работу с калькулятором");
                    break;
                }
                if (doing > 9)
                {
                    Console.WriteLine("такого числа в меню нет, попробуйте ещё раз(((");
                    continue;
                }
                if (doing < 6)
                {
                    Console.Write("Введите первое число: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    switch (doing)
                    {
                        case 1:
                            double sum = number1 + number2;
                            Console.WriteLine("Ваш результат сложения: " + sum);
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 2:
                            double raz = number1 - number2;
                            Console.WriteLine("Ваш результат вычитания: " + raz);
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 3:
                            double prod = number1 * number2;
                            Console.WriteLine("Ваш результат умножения: " + prod);
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 4:
                            double divs = number1 / number2;
                            if (number2 == 0)
                            {
                                Console.WriteLine("упс, ошибочка вышла: деление на ноль! попробуйте ещё раз!");
                                Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            }
                            else
                            {
                                Console.WriteLine("Ваш результат деления: " + divs);
                                Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            }
                            break;
                        case 5:
                            double power = Math.Pow(number1, number2);
                            Console.WriteLine("Ваш результат нахождения степени числа: " + power);
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 9:
                            Console.WriteLine("Вы завершили работу с калькулятором");
                            break;
                        default:
                            Console.WriteLine("такого числа в меню нет, попробуйте ещё раз((( ");
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            continue;
                    } 
                }
                if (doing >= 6)
                {

                        Console.Write("Введите число: ");
                        double number11 = Convert.ToDouble(Console.ReadLine());
                        switch (doing)
                        { 
                        case 6:
                            double sqrtroot = Math.Sqrt(number11);
                            if (number11 < 0)
                            {
                                Console.WriteLine("упс, ошибочка вышла: не бывает корней из отрицательных чисел! попробуйте ещё раз!");
                                Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            }
                            else
                            {
                                Console.WriteLine("Ваш результат нахождения квадратного корня из числа: " + sqrtroot);
                                Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            }
                          
                            break;
                        case 7:
                            double procent1 = number11 * 0.01;
                            Console.WriteLine("Ваш результат нахождения процента от числа: " + procent1);
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 8:
                            double factorial=1;
                            for (int i = 1; i <= number11; i++) 
                            {
                                factorial = factorial * i;
                            }
                            if (number11 < 0)
                            {
                                Console.WriteLine("упс, факториалы определены для натуральных чисел и нуля! попробуйте ещё раз!");
                            }
                            else
                            {
                                Console.WriteLine("Ваш результат нахождения факториала: " + factorial);
                            }
                    Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;
                        case 9:
                            Console.WriteLine("Вы завершили работу с калькулятором");
                            break;
                        default:
                            Console.WriteLine("такого числа в меню нет, попробуйте ещё раз((( ");
                            Console.WriteLine("введите номер операции (1-8) снова или нажмите '9', чтобы завершить работу калькулятора");
                            break;

                        }  
                } 
                Console.WriteLine(" ");
                
            } 
            while (doing != 9);
        }
    }
}