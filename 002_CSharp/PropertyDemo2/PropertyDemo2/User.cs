using System.Runtime.InteropServices;

namespace PropertyDemo2
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public User(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }

        public User()
        {
            
        }
    }
}