using System;
using System.Collections.Generic;
using System.Linq;

namespace Train {
    class Train {
        private Locomotive locomotive;
        private List<IWagon> wagons = new List<IWagon>();

        public List<IWagon> Wagons {
            get { return wagons; }
            set { wagons = value; }
        }

        public Locomotive Locomotive {
            get { return locomotive; }
            set { locomotive = value; }
        }

        public int WagonNumber { get; set; }
        public int SeatNumber { get; set; }

        public Train() { }

        public Train(Locomotive locomotive) {
            Locomotive = locomotive;
        }

        public void ConnectWagon(IWagon wagon) {
            if((Locomotive.Engine.EngineType == Engine.Type.Parni) && (Wagons.Count < 5)) {
                Wagons.Add(wagon);
            } else if(Locomotive.Engine.EngineType != Engine.Type.Parni) {
                Wagons.Add(wagon);
            } else {
                Console.WriteLine("Parni lokomotiva může mít max 5 vagonů");
            }
        }

        public void DisconnectWagon(IWagon wagon) {
            if(Wagons.Contains(wagon)) {
                Wagons.Remove(wagon);
            } else {
                Console.WriteLine("Nelze odstranit vagon");
            }
        }

        public override string ToString() {
            string wagonsInfo = string.Join(", ", Wagons.Select(w => w.GetType().Name));
            return $"{Locomotive} Pripojene vagony: {wagonsInfo}";
        }
    }

}
