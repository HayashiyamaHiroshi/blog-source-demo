namespace InterfaceConvert
{
    public class Subaru : IVehicle , ICar
    {
        public string MoveSound => "ブーブー";
        public string Maker => "Subaru";
    }
}