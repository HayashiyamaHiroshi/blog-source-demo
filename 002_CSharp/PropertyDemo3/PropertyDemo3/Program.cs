using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] props = typeof(Car).GetProperties();

            //foreach (PropertyInfo prop in props)
            //{
            //    Console.WriteLine($@"{prop.Name} : {prop.PropertyType}");
            //}

            //var car = new Car(1,"インプレッサ","subaru");
            //car.Name = "フォレスター";

            var car = new Car(1, "インプレッサ", "subaru");
            var carNameProp = props.First(item => item.Name == nameof(Car.Name));
            carNameProp.SetValue(car,"フォレスター");
            Console.WriteLine(car.Name);

            //foreach (PropertyInfo prop in props)
            //{
            //    Console.WriteLine($@"{prop.Name} : {prop.GetValue(car)}");
            //}

            Console.ReadLine();
        }
    }
}
