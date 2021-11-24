using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputA = int.Parse(Console.ReadLine());        // 500 -> 10 point
        var inputB = int.Parse(Console.ReadLine());        // 100 ->  2 point
        var inputC = int.Parse(Console.ReadLine());        // 50  ->  1 point
        var inputX = int.Parse(Console.ReadLine());        // 数
        //var input2 = Console.ReadLine().Split(' ').Select(r => uint.Parse(r));
        //var inputMax = input2.Max();

        var maxVal = 500 * inputA + 100 * inputB + 50 * inputC;

        if (maxVal < inputX)
        {
            Console.WriteLine("0");
            return;
        }

        if (inputX % 50 != 0)
        {
            Console.WriteLine("0");
            return;
        }

        // ここまで来たら、少なくとも1通りの表現方法はある
        var solveCount = 0;

        for (var i = 0; i < inputA+1; i++)
        {
            for (var j = 0; j < inputB+1; j++)
            {
                for (var k = 0; k < inputC+1; k++)
                {
                    if (500*i+100*j+50*k == inputX)
                    {
                        solveCount++;
                        //Console.WriteLine($"A: {i}, B: {j}, C: {k}");

                        break;
                    }
                }
            }
        }

        Console.WriteLine(solveCount);
    }
}

