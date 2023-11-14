using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class BusinessWagon : PersonalWagon {
        private Person steward;
        public BusinessWagon(): base(30) { }
        public BusinessWagon(Person steward, int numberOfChairs):base(numberOfChairs) {
            Steward = steward;
        }
        public Person Steward { get { return steward; } set { steward = value; } }
        public override string ToString() {
            return $"{base.ToString()} Jméno stevarda: {Steward}";
        }
    }
}
