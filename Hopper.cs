using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Hopper {
        private double loadingCapacity;
        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }
        public Hopper(double tonnage) { loadingCapacity = tonnage;}
        public override string ToString() {
            return $"{GetType().Name} {loadingCapacity}";
        }
    }
}
