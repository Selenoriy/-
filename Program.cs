
using System; // Подключение библиотек
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console; // Доступ к статическим членам и вложенным типам
namespace _01_Structure // Пространство имен (Название проекта)
{



    
    class Program // Описание класса

    {

        


        










        static void Main(string[] args) // Метод Main
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int k;
            WriteLine("Выбор решения задачи 1, 2 или 3:");
            k=Convert.ToInt32(Console.ReadLine());
            WriteLine($"Выбрана задача: {k}");
            switch (k)
            {
                case 1:
                    Console.WriteLine("Задан одномерный массив из 15 элементов:");
                    int[] mass = new int[15];
                    Random rand = new Random();
                    for (int i = 0; i < 15; i++)
                    {
                        mass[i] = rand.Next(-100, 100);
                    }
                    int n = 0;
                    for (int i = 0; i < 15; i++)
                    {
                        Console.WriteLine(mass[i]);

                    }
                    for (int i = 0; i < 15; i++)
                    {
                        if (mass[i] < 0)
                            n++;
                    }

                    Console.WriteLine($"В заданном массиве отрицательных элементов: {n} ");

                    break;
                case 2:
                    Console.WriteLine("Задан матрица 3 на 4:");
                    int[,] massiv = new int[3,4];
                    Random randd = new Random();
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 4; j++)
                            massiv[i,j] = randd.Next(-100, 100);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 4; j++) 
                            Console.Write(massiv[i,j] + " ");
                        Console.WriteLine();
                    }
                    int[] tosort_mass = new int[4];
                    Console.WriteLine("Отсортированный по убыванию(построчно) массив:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            tosort_mass[j] = massiv[i, j];
                        }
                        Array.Sort(tosort_mass);
                        Array.Reverse(tosort_mass);
                        for (int j = 0; j < 4; j++)
                            Console.Write(tosort_mass[j] + " ");
                        Console.WriteLine();
                    }

                    break;
                
                case 3:
                    List<string>  Autor= new List<string>() { "Сам Ты Пен Sbornik mudrostey", "Сам Ты Пен Sbornik glupostey",
                                                                "Lu hau Tsi Исскуство невойны","Lu hau Tsi Iskusstvo voyni",
                                                            "Итадаляк Etc. Этсетеризм","Итадаляк Etc. Ustal" };
                    Console.WriteLine("Библиотека:");
                    for (int i = 0; i < 6; i++)
                    {
                        string a = Autor[i]; 
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("Произведения какого автора вывести?");
                    Console.WriteLine("1.Сам Ты Пен ");
                    Console.WriteLine("2.Lu hau Tsi");
                    Console.WriteLine("3.Итадаляк Etc.");
                    Console.WriteLine("Введите номер.");
                    int g= Convert.ToInt32(Console.ReadLine());
                    switch (g)
                    {

                        case 1:
                            Console.WriteLine(Autor[0]);
                            Console.WriteLine(Autor[1]);
                            break;
                        case 2:
                            Console.WriteLine(Autor[2]);
                            Console.WriteLine(Autor[3]);
                            break;
                        case 3:
                            Console.WriteLine(Autor[4]);
                            Console.WriteLine(Autor[5]);
                            break;
                        default:
                            WriteLine("Вы ввели неверное значение :(");
                            break;
                    }

                        break;
                default:
                    WriteLine("Вы ввели неверное значение :(");
                    break;
            }



            Console.ReadLine();
        }
    }
}
