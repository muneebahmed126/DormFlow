
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FormFlow.Model.Accomodation
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public int Capacity { get; private set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            IsAvailable = true;
        }
    }
}
