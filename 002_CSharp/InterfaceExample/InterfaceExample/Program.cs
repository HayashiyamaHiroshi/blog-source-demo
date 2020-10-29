using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloList = new IGetHello[]
            {
                new CSharpHello()
                , new VBnetHello()
                , new FreeHello("Python")
                , new FreeHello("JavaScript"),  
            };

            helloList.ToList().ForEach(ShowConsole);
            Console.ReadLine();
        }

        static void ShowConsole(IGetHello sayHello)
        {
            Console.WriteLine(sayHello.GetHello());

        }
    }
}
