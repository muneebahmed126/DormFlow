using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormFlow.Model.Users;

namespace FormFlow.Model.Accomodation
{
    public class RoomAllocation
    {
        public User User { get; private set; }
        public Room Room { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime? CheckOut { get; private set; }

        public RoomAllocation(User user, Room room)
        {
            User = user;
            Room = room;
            CheckIn = DateTime.Now;
            room.IsAvailable = false;
        }

        public void Checkout()
        {
            CheckOut = DateTime.Now;
            Room.IsAvailable = true;
        }
    }
}
