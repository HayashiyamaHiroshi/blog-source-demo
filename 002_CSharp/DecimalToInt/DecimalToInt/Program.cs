using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dec = (decimal) 1.111111;
            //int parsedInt = decimal.ToInt16(dec);
            //Console.WriteLine(parsedInt);

            //int parsedInt = dec.ToInt();
            //Console.WriteLine(parsedInt);
            //Console.ReadLine();

            //// => 1
            //Console.WriteLine(((decimal) 1.1111).ToInt());

            //// => 1
            //Console.WriteLine(((decimal) 1.9999).ToInt());

            //// => 0
            //Console.WriteLine(((decimal) 0.9999).ToInt());

            //// => 11
            //Console.WriteLine(((decimal) 11.55551).ToInt());

            //// => -11
            //Console.WriteLine(((decimal) -11.111).ToInt());

            //// => -11
            //Console.WriteLine(((decimal) -11.999).ToInt());

            //// => 0
            //Console.WriteLine(((decimal) -0.999).ToInt());

            // => 2
            Console.WriteLine(((decimal)1.5).ToInt(ParseType.切り上げ));

            // => 1
            Console.WriteLine(((decimal)1.5).ToInt(ParseType.切り捨て));

            // => 2
            Console.WriteLine(((decimal)1.5).ToInt());

            Console.ReadLine();

        }
    }

    static class DecimalExtension
    {
        public static int ToInt(this decimal dec, ParseType type = ParseType.四捨五入)
        {
            var roundedDec = default(Decimal);
            switch (type)
            {
                case ParseType.切り上げ:
                    roundedDec = Math.Ceiling(dec);
                    break;
                case ParseType.切り捨て:
                    roundedDec = Math.Floor(dec);
                    break;
                default:
                    roundedDec = Math.Round(dec, MidpointRounding.AwayFromZero);
                    break;
            }

            return decimal.ToInt16(roundedDec);
        }
    }

    public enum ParseType
    {
        四捨五入 = 1,
        切り捨て,
        切り上げ
    }
}
