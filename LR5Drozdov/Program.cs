using System;

namespace LR5Drozdov
{

    class Program
    {
        static void Main(string[] args)
        {
            DrozdovConcern motorshow = new DrozdovConcern();
            while (true)
            {
                Console.WriteLine("\n\t\tМеню:\n" +
                           "1. Добавить автомобиль.\n" +
                           "2. Добавить спорткар.\n" +
                           "3. Вывести данные об автомобилях на экран.\n" +
                           "4. Считать данные об автомобилях из файла.\n" +
                           "5. Вывести данные об автомобилях в файл.\n" +
                           "6. Очистить список.\n" +
                           "0. Закрыть приложение.\n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            motorshow.add();
                            break;
                        }
                    case 2:
                        {
                            motorshow.add_sportcar();
                            break;
                        }
                    case 3:
                        {
                            motorshow.show();
                            break;
                        }
                    case 4:
                        {
                            motorshow.FromFile();
                            break;
                        }
                    case 5:
                        {
                            motorshow.ToFile();
                            break;
                        }
                    case 6:
                        {
                            motorshow.clear();
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("\nОшибка ввода, введите значение из списка.\n");
                            break;
                        }
                }
            }
        }
    }
}
