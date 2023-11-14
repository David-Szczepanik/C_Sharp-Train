using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Locomotive {
        private Person driver;
        private Engine engine;
        public Locomotive() { }
        public Locomotive(Person driver, Engine engine) {
            Driver = driver; //mozna zmena na this.driver = driver
            Engine = engine;
        }
        public Person Driver { get { return driver; } set { driver = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public override string ToString() {
            return $"Lokomotiva má řidiče: {driver} a motor: {engine}";
        }
    }
}
