using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class EonomyWagon : PersonalWagon {
        public EonomyWagon(int numberOfChairs) { NumberOfChairs = numberOfChairs; }
        public override string ToString() {
            return $"{NumberOfChairs}";
        }
    }
}
