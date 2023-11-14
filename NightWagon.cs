using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class NightWagon : PersonalWagon {
        private List<Bed> beds = new List<Bed>();
        private int numberOfBeds;
        List<Bed> Beds { get { return beds; } set { beds = value; } }
        public int NumberOfBeds { get { return beds.Count; } set { numberOfBeds = value; } }
        public NightWagon() : base(5) { }
        public NightWagon(int numberOfBeds, int numberOfChairs) : base(numberOfChairs) {
            NumberOfBeds = numberOfBeds;
            for(int i = 0; i < numberOfBeds; i++) {
                Bed bed = new Bed(i);
                Beds.Add(bed);
            }
        }
        public override string ToString() {
            return $"{base.ToString()} Počet postelí: {numberOfBeds}";
        }
    }
}
