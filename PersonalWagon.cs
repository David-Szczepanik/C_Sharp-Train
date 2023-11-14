using System;
using System.Collections.Generic;

namespace Train {
    class PersonalWagon : IWagon {
        private List<Door> doors = new List<Door>();
        private List<Chair> seats = new List<Chair>();
        private int numberOfChairs;

        public List<Door> Doors { get { return doors; } private set { doors = value; } }
        public List<Chair> Seats { get { return seats; } private set { seats = value; } }

        public int NumberOfChairs {
            get { return numberOfChairs; }
            set { numberOfChairs = value; }
        }

        public PersonalWagon(int numberOfChairs) {
            NumberOfChairs = numberOfChairs;
        }

        public override string ToString() {
            return $"Typ vlaku: {GetType().Name} Počet sedadel: {NumberOfChairs}";
        }

        public void Connect(Train tr) {
            if(tr != null && !tr.Wagons.Contains(this)) {
                tr.Wagons.Add(this);
                Console.WriteLine($"Vagon {this} připojen k vlaku {tr}");
            } else {
                Console.WriteLine("Vagon je již připojen k vlaku nebo je vlak null");
            }
        }

        public void Disconnect(Train tr) {
            if(tr != null && tr.Wagons.Contains(this)) {
                tr.Wagons.Remove(this);
            } else {
                Console.WriteLine("Vagon je připojen k jinému vlaku nebo je vlak null");
            }
        }
    }
}
