using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFlow.Model.Accomodation
{ 
    public abstract class Building
    {
        public string Name { get; protected set; }

        protected Building(string name)
        {
            Name = name;
        }
    }
}
