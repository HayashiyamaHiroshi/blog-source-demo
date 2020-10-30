using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtenssionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 2;

            //// 2の2乗
            //Console.WriteLine(num.Square());
            //// 2の3乗
            //Console.WriteLine(num.Square().Square());
            //// 2の4乗
            //Console.WriteLine(num.Square().Square().Square());

            //Console.ReadLine();

            //string str = "Hello World";
            //Console.WriteLine(str.Decoration());
            //Console.ReadLine();

            var dog = new Dog();
            var cat = new Cat();
            dog.Roar();
            cat.Roar();
            Console.ReadLine();
        }
    }

    public static class IntExtenssionMethod
    {
        public static int Square(this int num)
        {
            return num * num;
        }
    }

    public static class StringExtenssionMethod
    {
        public static string Decoration(this string str)
        {
            return $@"***{str}***";
        }
    }
}
