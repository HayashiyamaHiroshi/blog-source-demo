using System;
using System.Runtime.Remoting.Messaging;

namespace CallBackNDelegate
{
    public static class Delegate
    {
        public delegate string GetHelloDelegate(string str);

        public delegate void SayHelloDelegate();

        public static void Say()
        {
            var func = new SayHelloDelegate(() => Console.WriteLine("Hello World"));
            func();
        }

        public static void Say2()
        {
            var func = new GetHelloDelegate(str => $@"Hello {str}");
            Console.WriteLine(func("CSharp"));
            Say3((str => $@"Hello {str}"));
        }

        public static void Say3(GetHelloDelegate func)
        {
            Console.WriteLine(func("CSharp"));
        }
    }
}