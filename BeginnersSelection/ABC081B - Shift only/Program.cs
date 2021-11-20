using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var input2 = Console.ReadLine().Split(' ').Select(r => uint.Parse(r));
        var inputMax = input2.Max();

        uint t = 0;

        foreach(var item in input2)
        {
            t |= item;
        }

        var s = 0;

        if (t == 0)
        {
            Console.WriteLine(s);
            return;
        }

        while ((t & 1) != 1)
        {
            s++;
            t >>= 1;
        }

        Console.WriteLine(s);
    }
}

