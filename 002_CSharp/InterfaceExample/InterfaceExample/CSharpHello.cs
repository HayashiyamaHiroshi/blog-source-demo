using System;

namespace InterfaceExample
{
    public class CSharpHello : IGetHello
    {
        public string GetHello()
        {
            return "Hello CSharp";
        }
    }
}