using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        // 整数の入力
        //int a = int.Parse(Console.ReadLine());
        // スペース区切りの整数の入力
        string[] input = Console.ReadLine().Split(' ');
        int b = int.Parse(input[0]);
        int c = int.Parse(input[1]);
        // 文字列の入力
        string s = (((b*c) & 1) == 1) ? "Odd" : "Even";
        //出力
        Console.WriteLine(s);
    }
}

