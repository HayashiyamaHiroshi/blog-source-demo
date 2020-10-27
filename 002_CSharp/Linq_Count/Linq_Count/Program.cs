using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // 山を含む要素をカウント
            // Case1();
            
            //関数を用いて山を含む要素をカウント
            // Case2();
            //
            // // デリゲート的感じで関数をそのまま投げて山を含む要素をカウント
            // Case3();
            //
            // CountをAnyに
            Case4();


            Console.ReadLine();
        }

        static void Case1()
        {
            var strs = new List<string>()
            {
                "山田",
                "鈴木",
                "小林",
                "山岡",
                "小山",
                "鈴原"
            };

            var res = strs.Count(item => item.Contains("山"));
            Console.WriteLine(res);
        }

        static void Case2()
        {
            var strs = new List<string>()
            {
                "山田",
                "鈴木",
                "小林",
                "山岡",
                "小山",
                "鈴原"
            };

            var res = strs.Count(item => IsContainYama(item));
            Console.WriteLine(res);
        }

        static void Case3()
        {
            var strs = new List<string>()
            {
                "山田",
                "鈴木",
                "小林",
                "山岡",
                "小山",
                "鈴原"
            };

            var res = strs.Count(IsContainYama);
            Console.WriteLine(res);
        }

        static void Case4()
        {
            var strs = new List<string>()
            {
                "山田",
                "鈴木",
                "小林",
                "山岡",
                "小山",
                "鈴原"
            };

            var res = strs.Any(IsContainYama);
            Console.WriteLine(res);
        }

        static bool IsContainYama(string str)
        {
            return str.Contains("山");
        }
    }
}
