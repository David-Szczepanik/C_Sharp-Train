using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Chair {
        private bool nearWindow;
        private int number;
        private Person reserved;
        public bool IsReserved { get; set; }
        public bool NearWindow { get { return nearWindow; } set { nearWindow = value; } }
        public int Number { get { return number; } set { number = value; } }
        public Person Reserved { get { return reserved; } set { reserved = value; } }
        public Chair() { }
        public Chair(int number) {
            Number = number; //this.number
            IsReserved = false;
        }
        public Chair(int number, Person reserved) : this(number) {
            Reserved = reserved;
        }
        public Chair(int number, Person reserved, bool nearWindow) : this(number, reserved) { NearWindow = nearWindow; }

        public void ReserveChair(Person person) {
            if(!IsReserved) {
                Reserved = person;
                IsReserved = true;
            } else {
                Console.WriteLine($"Židle {Number} je už rezervovaná na jméno {person.FirstName} {person.LastName}");
            }
        }
    }
}


