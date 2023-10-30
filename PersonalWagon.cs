using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class PersonalWagon {
        private List<Door> doors = new List<Door>();
        private List<Chair> sits = new List<Chair>();
        private int numberOfChairs;
        public List<Door> Doors { get { return doors; } set { doors = value; } }
        public List<Chair> Sits { get { return sits; } set { sits = value; } }
        public int NumberOfChairs { get { return numberOfChairs; } set { numberOfChairs = value; } }

       
    }
}
