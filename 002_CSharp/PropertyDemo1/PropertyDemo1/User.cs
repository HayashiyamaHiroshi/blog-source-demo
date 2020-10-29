using System.Net.Sockets;

namespace PropertyDemo1
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private int Age;
        public string Address { get; set; }

        public User(int age, int id, string name, string address)
        {
            Age = age;
            ID = id;
            Name = name;
            Address = address;
        }

        public User()
        {
            
        }
    }
}