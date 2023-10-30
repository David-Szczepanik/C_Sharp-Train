using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Chair {
        private bool nearWindow;
        private int number;
        private bool reserved;
        public bool NearWindow { get { return nearWindow; } set { nearWindow = value; } }
        public int Number { get { return number; } set { number = value; } }
        public int ChairNumber { get; set; }
        public bool IsReserved { get; set; }
        public Person Reserved { get; set; }
        public Chair(bool nearWindow, int number, bool reserved) {
            this.nearWindow = nearWindow;
            this.number = number;
            this.reserved = reserved;
        }

        public Chair(int chairNumber) {
            ChairNumber = chairNumber;
            IsReserved = false;
        }
        public void ReserveChair(Person person) {
            if (!IsReserved) {
                Reserved = person;
                IsReserved = true;
            }
            else {
                Console.WriteLine($"židle {ChairNumber} je už rezervovaná");
            }
        }
        public override string ToString() {
            return $"Chair {ChairNumber}";
        }
    }
}


