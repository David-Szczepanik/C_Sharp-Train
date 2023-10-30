using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class BusinessWagon : PersonalWagon {
        private Person steward;
        public BusinessWagon(Person steward) {
            Steward = steward;
        }
        public BusinessWagon() { }
        public Person Steward { get { return steward; } set { steward = value; } }

        public BusinessWagon(Person steward, int numberOfChairs) { Steward = steward; NumberOfChairs = numberOfChairs; }
        public override string ToString() {
            return $"{GetType().Name} {NumberOfChairs} {Steward}";
        }
    }
}
