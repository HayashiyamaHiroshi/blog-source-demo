using System.Net.Sockets;

namespace PropertyDemo1
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Age;
        public string Address { get; set; }

        private string _gender;
        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public User(int age, int id, string name, string address,string gender)
        {
            Age = age;
            ID = id;
            Name = name;
            Address = address;
            _gender = gender;
        }

        public User()
        {
            
        }
    }
}