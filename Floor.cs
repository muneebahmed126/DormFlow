namespace FormFlow.Model.Accomodation
{
    public class Floor
    {
        public int FloorNumber { get; private set; }
        public List<Room> Rooms { get; private set; }

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            Rooms = new List<Room>();
        }
    }
}


