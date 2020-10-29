using System;

namespace CallBackNDelegate
{
    public static class CallBack
    {
        public static string GetHello(string str)
        {
            return $@"Hello {str}";
        }

        public static void Say2(Func<string, string> func)
        {
            var hello = func("CSharp");
            Console.WriteLine(hello);
        }

        public static void SayHello()
        {
            Console.WriteLine("HelloWorld");
        }

        public static void Say(Action action)
        {
            action();
        }
    }
}