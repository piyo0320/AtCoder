using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();

        if (input1 == "##")
        {
            Console.WriteLine("Yes");
            return;
        }

        if (input2 == "##")
        {
            Console.WriteLine("Yes");
            return;
        }

        var blackPosi1 = input1.IndexOf("#");
        var blackPosi2 = input2.IndexOf("#");

        if (blackPosi1 == blackPosi2)
        {
            Console.WriteLine("Yes");
            return;
        }

        Console.WriteLine("No");
        return;
    }
}

