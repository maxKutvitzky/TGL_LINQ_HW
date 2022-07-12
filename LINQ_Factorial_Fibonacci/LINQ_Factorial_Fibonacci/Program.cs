using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("==========Factorial with LINQ==========\n");
foreach (int item in FactorialUsingLinq(10))
{
    Console.Write(item+" ");
}
Console.WriteLine("\n\n==========Fibonacci with LINQ==========\n");
foreach (int item in FibonacciUsingLinq(10))
{
    Console.Write(item + " ");
}

Console.WriteLine();


static List<int> FactorialUsingLinq(int range)
{
    Console.WriteLine($"Factorial of number {range}:");
    int temp = 1;
    var result = Enumerable.Range(1, range).Select(number =>
    {
        temp *= number;
        return temp;
    });
    return result.ToList();
}

static List<int> FibonacciUsingLinq(int range)
{
    Console.WriteLine($"Fibonacci of {range} members:");
    int sum = 0, num = 1, temp;
    var result = Enumerable.Range(0, range).Select(number =>
    {
        if (number == 0) return number;
        temp = sum;
        sum = num;
        num += temp;
        return sum;
    });
    return result.ToList();
}
