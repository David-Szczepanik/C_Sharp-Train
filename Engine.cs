using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Engine {
        public enum Type {
            Diesel,
            Elektricka,
            Parni
        }
        private Type type;
        public Type EngineType { get { return type; } set { type = value; } }
        public Engine(Type type) { this.type = type; }
        public override string ToString() {
            return type.ToString();
        }
    }
}

