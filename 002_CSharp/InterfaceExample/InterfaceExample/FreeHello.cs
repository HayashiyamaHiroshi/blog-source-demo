using System;

namespace InterfaceExample
{
    public class FreeHello : IGetHello
    {
        private string _helloItem;
        public FreeHello(string helloItem)
        {
            _helloItem = helloItem;
        }

        public string GetHello()
        {
            return $@"Hello {_helloItem}";
        }
    }
}