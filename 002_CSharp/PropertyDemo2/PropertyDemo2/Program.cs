using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var user = new User(1, "鈴木", "東京都墨田区");
            //PropertyInfo[] props = typeof(User).GetProperties();
            //// ここでAddressのプロパティの情報を抜き出して
            //var addressProp = props.FirstOrDefault(item => item.Name == nameof(User.Address));

            //// ここで上記プロパティ情報にインスタンスを投げてデータを取得してる。
            //Console.WriteLine(addressProp.GetValue(user));
            //Console.ReadLine();

            //PropertyInfo[] props = typeof(User).GetProperties();
            //var propNames = props.Select(prop => prop.Name);
            //Console.WriteLine(String.Join(",",propNames.ToArray()));
            //Console.ReadLine();

            var user = new User(1, "鈴木", "東京都墨田区");
            PropertyInfo[] props = typeof(User).GetProperties();
            // ここでAddressのプロパティの情報を抜き出して
            var addressProp = props.FirstOrDefault(item => item.Name == nameof(User.Address));

            // ここで上記プロパティ情報にインスタンスを投げてデータを取得してる。
            Console.WriteLine(addressProp.GetValue(user));

            // ここで値を変える
            addressProp.SetValue(user,"東京都中央区");
            Console.WriteLine(addressProp.GetValue(user));
            Console.ReadLine();


        }
    }
}
