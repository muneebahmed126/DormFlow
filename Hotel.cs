namespace FormFlow.Model.Accomodation
{
    public class Hotel : Building
    {
        public List<Floor> Floors { get; private set; }

        public Hotel(string name) : base(name)
        {
            Floors = new List<Floor>();
        }
    }
}
