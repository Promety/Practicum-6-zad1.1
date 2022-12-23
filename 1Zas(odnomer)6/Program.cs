using System;

namespace _1Zas_odnomer_6
{
    class Program
    {
        static int[] Input(out int n)
        {
            
            Console.WriteLine("Сколько элементов массива ? : ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Ошибка, Введите Кол-во элементов заново\n");
            int[] G = new int[n];
            Console.WriteLine("Теперь, заполните массив числами :");
            for (int j = 0; j < n; j++)
            {
                Console.Write("[{0}]= ", j);
                while (!int.TryParse(Console.ReadLine(), out G[j]))
                {
                    Console.Write("Ошибка" + $"Введите заново [{j}]: ");
                }
             }

            int sum = 0;
            double count = 0;
            for (int j = 0; j < n; j++)
            {
                sum += G[j];
                count++;
            }
            Console.WriteLine("Среднееарифметическое будет : " + sum / count);
            Console.ReadKey();
            return G;
        }
        static void Main(string[] args)
        {
            int n;           
            int[] myArray = Input(out n);
        }
    }
    
}
