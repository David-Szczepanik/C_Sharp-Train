using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vlak;

namespace Train {
    internal class Train {
        Locomotive locomotive;
        private List<object> wagons = new List<object>();
        public List<object> Wagons { get { return wagons; } set { wagons = value; } }
        Locomotive Locomotive { get { return locomotive; } set { locomotive = value; } }
        public int wagonNumber { get { return wagonNumber; } set { wagonNumber = value; } }
        public int seatNumber { get { return seatNumber; } set { seatNumber = value; } }
        public Train() { Wagons = wagons; }
        public Train(Locomotive locomotive) { Locomotive = locomotive; }
        public void ConnectWagon(object wagon) {
            if ((Engine.Type.parni.ToString() == "parni") && (Wagons.Count < 5)) { Wagons.Add(wagon); }
            else { Console.WriteLine("Parni lokomotiva může mít max 5 vagonů"); }
        }
        public void DisconnectWagon(object wagon) {
            if (Wagons.Count > 0) { Wagons.Remove(wagon); }
            else { Console.WriteLine("Nelze odstranit vagon"); }
        }
        public override string ToString() {

            string vagony = "";
            foreach (Object o in wagons) { vagony += o.GetType().Name + ", "; }
            return this.locomotive + "Pripopjene vagony:" + vagony;
        }
    }
}

