using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var N = int.Parse(Console.ReadLine());

        var arr = new List<(int, int, int)>();

        for (int i = 0; i < N ; i++)
        {
            var temp = Console.ReadLine().Split(" ");

            arr.Add((int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2])));
        }

        var nowT = 0;
        var nowX = 0;
        var nowY = 0;

        for (int j = 0; j < N ;j++)
        {
            var t = arr[j].Item1 - nowT;
            var x = Math.Abs(arr[j].Item2 - nowX);
            var y = Math.Abs(arr[j].Item3 - nowY);

            // 移動すべき距離
            var dist = x + y;

            if (dist - t > 0)
            {
                // 移動距離が長すぎる
                Console.WriteLine("No");
                return;
            }

            if ((t - dist) % 2 != 0)
            {
                // 移動不可
                Console.WriteLine("No");
                return;
            }

            nowT = arr[j].Item1;
            nowX = arr[j].Item2;
            nowY = arr[j].Item3;
        }

        Console.WriteLine("Yes");
        return;
    }
}

