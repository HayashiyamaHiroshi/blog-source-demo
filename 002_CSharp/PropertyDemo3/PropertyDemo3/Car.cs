namespace PropertyDemo3
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Maker { get; set; }

        public Car(int id, string name, string maker)
        {
            ID = id;
            Name = name;
            Maker = maker;
        }

        public Car()
        {
            
        }
    }
}