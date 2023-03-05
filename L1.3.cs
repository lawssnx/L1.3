using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[]args)
    {
        Console.Write("Введіть цілі числа через пробіл: ");
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var featured = numbers.Where(x => x % 2 != 0)
            .OrderBy(x => x);
        Console.Write("Непарні числа у порядку зростання:");

        foreach (int s in featured)
        {
            Console.WriteLine(s);
        }

    }
}
