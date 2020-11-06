namespace DataGridViewWithDataTable
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public User(int id, string name, int age, string address)
        {
            ID = id;
            Name = name;
            Age = age;
            Address = address;
        }
    }
}