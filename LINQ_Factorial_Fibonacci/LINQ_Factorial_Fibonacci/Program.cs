using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("==========Factorial with LINQ==========\n");
Console.WriteLine(FactorialUsingLinqAggregate(10));
/*foreach (int item in FactorialUsingLinq(10))
{
    Console.Write(item+" ");
}*/

Console.WriteLine("\n\n==========Fibonacci with LINQ==========\n");
Console.WriteLine(FibonacciUsingLinqAggregate(10));
/*foreach (int item in FibonacciUsingLinq(10))
{
    Console.Write(item + " ");
}*/

Console.WriteLine();


static List<int> FactorialUsingLinq(int range)
{
    Console.Write($"Factorial of number {range}:");
    int temp = 1;
    var result = Enumerable.Range(1, range).Select(number =>
    {
        temp *= number;
        return temp;
    });
    return result.ToList();
}

static int FactorialUsingLinqAggregate(int range)
{
    Console.Write($"Factorial of number {range}: ");
    return Enumerable.Range(1, range).Aggregate((aValue, current) => aValue * current);
}

static int FibonacciUsingLinqAggregate(int range)
{
    Console.Write($"Fibonacci of {range} members: ");
    return Enumerable.Range(1, range)
        .Skip(2) //Skipping first two elements
        .Aggregate(new { Current = 1, Prev = 1 }, //Init accumulator value
            (x, index) => new { Current = x.Prev + x.Current, Prev = x.Current }) //Accumulator function
        .Current; //Returns the Current property of anonymous type
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
