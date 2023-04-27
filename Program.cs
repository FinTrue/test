using System;
using System.Linq;

namespace Library
{
    public class ZadanieOne
    {
        public static void One()
        {
            Console.Write("Введите число N: ");
            int n;
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out n);//conversion check
            if (check == true)
            {
                string result = string.Join(", ", Enumerable.Range(1, n)) + ".";// Adding a point by task
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ввод недопустимого символа. Выполнение прекращено");
            }
        }
    }
    public class ZadanieTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            int n;
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out n);
            if (check == true)//conversion check
            {
                if (n < 3 || n % 2 == 0)  // If N is an even number, exit the function.
                {
                    if (n % 2 == 0) { Console.WriteLine("Вы ввели четное N."); }
                    else { Console.WriteLine("Вы ввели N<3."); }//n<3 check
                    return;
                }
                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write("  ");
                        else Console.Write("# ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ввод недопустимого символа. Выполнение прекращено");
            }
        }
    }
    class program
    {
        static void Main()
        {
            ZadanieOne.One();
            ZadanieTwo.Two();
        }
    }
}