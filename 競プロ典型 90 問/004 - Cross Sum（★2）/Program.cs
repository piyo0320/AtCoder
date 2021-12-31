using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var sc = new Scanner();

        var (H, W) = sc.ReadInt2();
        var matrix = new int[H, W];
        var HSums = new long[H];
        var WSums = new long[W];

        // 入力
        for (int i = 0; i < H; i++)
        {
            var inputs = sc.ReadIntArray(W);
            HSums[i] = inputs.Sum();

            for (int j = 0; j < W; j++)
            {
                matrix[i,j] = inputs[j];

                WSums[j] += inputs[j];
            }
        }

        // 出力
        var sumMatrix = new long[H, W];
        var outputs = new string[W];

        for(int i = 0; i < H; i++)
        {
            var outputLine = new long[W];

            for (int j = 0; j < W; j++)
            {
                var item = HSums[i];

                item += WSums[j];
                item -= matrix[i,j];

                outputLine[j] = item;

                //sumMatrix[i,j] = item;
            }

            Console.WriteLine(string.Join(" ",outputLine));
        }

        return;
    }

    // ==============================================
    //  以降はメソッドやらライブラリ群
    // ==============================================

    /// <summary>
    ///  コンソールの入力をスキャンする
    /// </summary>
    public class Scanner
    {
        /// <summary>
        ///  Intで1つ読む
        /// </summary>
        /// <returns></returns>
        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///  Intで2つ読む
        /// </summary>
        /// <returns></returns>
        public (int, int) ReadInt2()
        {
            var inputs = Console.ReadLine().Split(" ").Select(r => int.Parse(r)).ToList();

            return (inputs[0], inputs[1]);
        }

        /// <summary>
        ///  INTを(size)個読んで配列にする
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int[] ReadIntArray(int size)
        {
            var data = new int[size];
            var inputs = Console.ReadLine().Split(" ").Select(r => int.Parse(r)).ToList();

            for (int i = 0; i < size; i++)
            {
                data[i] = inputs[i];
            }

            return data;
        }
        /// <summary>
        ///  INT2つをN個読む
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] ReadNInt2Array(int n)
        {
            var data = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ").Select(r => int.Parse(r)).ToList();
                data[i, 0] = inputs[0];
                data[i, 1] = inputs[1];
            }

            return data;
        }
    }

    /// <summary>
    ///  グラフ用のクラス。以下のプロパティを持つ。ただし、頂点0は使用しない。
    ///  ・頂点数
    ///  ・経路とそのコスト
    /// </summary>
    public class MyGraph
    {
        public long Nodes { get; set; }

        /// <summary>
        ///  エッジがつながっている頂点とその移動コストの組。
        ///  例えばWays[1] = {<2,3>, <5,5>} -> 頂点1と頂点2,5にエッジがあり、移動コストがそれぞれ3,5。
        /// </summary>
        public Dictionary<int, int>[] Ways { get; }

        /// <summary>
        ///  行先の頂点とその移動コストの組。例えばWays[1] -> 頂点1からのパスと経路のリスト。
        ///  移動できない場合はコストに-1を入れる。
        /// </summary>
        public Dictionary<int, int>[] WayWithCosts { get; }

        public MyGraph(int size)
        {
            Nodes = size;
            Ways = Enumerable.Range(0, size + 1).Select(_ => new Dictionary<int, int>()).ToArray();
            WayWithCosts = Enumerable.Range(0, size + 1).Select(_ => new Dictionary<int, int>()).ToArray();
        }

        /// <summary>
        ///  頂点をつなぐ
        /// </summary>
        /// <param name="start"></param>
        /// <param name="dest"></param>
        public void Connect(int start, int dest)
        {
            Ways[start].Add(dest, 1);
            Ways[dest].Add(start, 1);
        }

        /// <summary>
        ///  頂点をつなぐ(コスト付き)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="dest"></param>
        public void Connect(int start, int dest, int cost)
        {
            Ways[start].Add(dest, cost);
            Ways[dest].Add(start, cost);
        }

        /// <summary>
        ///  距離を計算
        /// </summary>
        /// <param name="current">現在の頂点の位置</param>
        /// <param name="from">1つ前にいた頂点の位置</param>
        /// <param name="start">始点</param>
        /// <param name="cost">現在の頂点までのコスト</param>
        /// <returns></returns>
        public void SetDistByBFS(int current, int start, int from = 0, int cost = 0)
        {
            foreach (var item in Ways[current])
            {
                if (item.Key == from)
                {
                    // 来た道を戻ることになるので処理しない
                    continue;
                }

                // 子要素へのコストを格納
                WayWithCosts[start].Add(item.Key, cost + item.Value);

                SetDistByBFS(item.Key, start, current, cost + item.Value);
            }
        }
    }
}

