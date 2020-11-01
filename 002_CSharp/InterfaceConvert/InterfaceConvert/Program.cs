using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle plane = new Plane();

            if (plane is ICar car)
            {
                Console.WriteLine(car.Maker);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("PlaneはICarを継承していません。");
            Console.ReadLine();
        }
    }
}
