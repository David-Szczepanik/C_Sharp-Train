using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class NightWagon : PersonalWagon {
        private List<Bed> beds = new List<Bed>();
        private int numberOfBeds;
        List<Bed> Beds { get { return Beds; } set { Beds = value; } }
        public int NumberOfBeds { get { return beds.Count; } set { numberOfBeds = value; } }
        public NightWagon(int numberOfChairs, int numberOfBeds) { NumberOfChairs = numberOfChairs; NumberOfBeds = numberOfBeds; }
        public override string ToString() {
            return $"{GetType().Name} {numberOfBeds} {NumberOfChairs}";
        }
    }
}
