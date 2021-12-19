using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int a = 0;
            int b = 0;
            int w = 0;
            try
            {
                Console.Write("Введите целое число a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n    1 - сложение\n    2 - вычитание\n    3 - произведение\n    4 - частное");
                Console.Write("Ваш выбор:");
                w = Convert.ToInt32(Console.ReadLine());
                switch (w)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен: {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен: {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен: {0}", a * b);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен: {0}", a / b);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.ReadKey();
            }
    }
}
