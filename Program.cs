using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork0._03
{
    class Program
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int>();

            while (true)
            {
                int number;
                bool isOk = false;
                do
                {
                    Console.Write("Введите целое число: ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out number))
                    {
                        isOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Только числа, братан.");
                    }
                } while (!isOk);

                if (isOk)
                {
                    if (set.Add(number)) Console.WriteLine($"Что-то новенькое. Молодец!");
                    else Console.WriteLine($"Баян. Давай по-новой.");
                }
            }
        }
    }
}
