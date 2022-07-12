using System;
using System.Collections.Generic;
using System.Linq;

foreach (int item in FactorialUsingLinq(10))
{
    Console.Write(item+" ");
}

static List<int> FactorialUsingLinq(int range)
{
    int temp = 1;
    var result = Enumerable.Range(1, range).Select(number =>
    {
        temp = temp * number;
        return temp;
    });
    return result.ToList();
}
