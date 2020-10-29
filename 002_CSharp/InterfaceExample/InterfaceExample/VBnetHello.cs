using System;

namespace InterfaceExample
{
    public class VBnetHello : IGetHello
    {
        public string GetHello()
        {
            return "Hello Vb.net";
        }
    }
}