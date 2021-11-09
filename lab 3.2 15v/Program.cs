using System;

namespace lab_3._2_15v
{
    public class Program
    {
        private static int CalculatePower(int a, int b)
        {
            int result = 1;

            for (int i = 1; i <= b; i++)
                result *= a;

            return result;
        }

        public static void Main()
        {
            int n = 0, m = 0, resultSum = 0;

            Console.Write("Введите значение переменной n: ");
            n = int.Parse(Console.ReadLine());
            while (n <= 1)
            {
                Console.Write("Неверное значение данной переменной! Повторите ввод: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите значение переменной m: ");
            m = int.Parse(Console.ReadLine());
            while (m < 0)
            {
                Console.Write("Неверное значение данной переменной! Повторите ввод: ");
                m = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
                resultSum += CalculatePower(i, m);

            Console.WriteLine("Результат вычислений для заданных n и m: {0}", resultSum);

        }
    }
}
