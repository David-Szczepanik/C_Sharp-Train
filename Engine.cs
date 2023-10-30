using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Engine {
        public enum Type {
            diesel,
            elektricka,
            parni
        }
        private Type type;
        public Type EngineType { get { return type; } set { type = value; } }
        public Engine(Type type) { this.type = type; }
        public Engine(Type type, Type engineType) : this(type) {
            EngineType = engineType;
        }
        public override string ToString() {
            return type.ToString();
        }


        //private string type;
        //public string Type { get { return type; } set { type = value; } }
        //public Engine(string type) { Type = type; }


    }
}

