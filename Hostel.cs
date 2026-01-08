
using System;
using System.Collections.Generic;

namespace FormFlow.Model.Accomodation
{
    public class Hostel : Building
    {
        public List<Floor> Floors { get; private set; }

        public Hostel(string name) : base(name)
        {
            Floors = new List<Floor>();
        }
    }
}
