using System;

namespace Train {
    class Hopper : IWagon {
        private readonly double loadingCapacity;

        public double LoadingCapacity {
            get { return loadingCapacity; }
        }

        public Hopper(double tonnage) {
            loadingCapacity = tonnage;
        }

        public void Connect(Train train) {
            if(train != null && !train.Wagons.Contains(this)) {
                train.Wagons.Add(this);
                Console.WriteLine($"Hopper {this} připojen k vlaku {train}");
            } else {
                Console.WriteLine("Hopper je již připojen k vlaku nebo je vlak null");
            }
        }
        public void Disconnect(Train train) {
            if(train != null && train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
            } else {
                Console.WriteLine("Hopper je připojen k jinému vlaku nebo je vlak null");
            }
        }
        public override string ToString() {
            return $"Typ vlaku: {GetType().Name} Nosnost: {loadingCapacity}t";
        }
    }
}
