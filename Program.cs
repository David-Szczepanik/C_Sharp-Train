using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Program {
        public static void Main(string[] args) { 
            Person p1 = new Person("Jan", "Novák");
            Person steward = (p1);
            Person p2 = new Person("Karel", "Novák");
            Person p3 = new Person("Lenka", "Kozáková");
            Person driver = (p2);
            Person p4 = new Person("1", "Novy");

            BusinessWagon bw1 = new BusinessWagon(p3,20);

            NightWagon nw1 = new NightWagon(5, 10);
            Hopper h1 = new Hopper(150);
            Hopper h2 = new Hopper(150);
            Hopper h3 = new Hopper(150);
            Hopper h4 = new Hopper(150);
            //Engine e1 = new Engine(Engine.Type.diesel);
            Engine e1 = new Engine(Engine.Type.parni);

            Console.WriteLine(bw1.ToString());

            Train vlak = new Train();
            vlak.ConnectWagon(bw1);
            vlak.ConnectWagon(nw1);
            vlak.ConnectWagon(h1);
            Console.WriteLine(vlak.ToString());
            Console.WriteLine(e1.ToString());

            vlak.ConnectWagon(h2);
            vlak.ConnectWagon(h3);
            vlak.ConnectWagon(h4);

            Chair ch1 = new Chair(1);
            
            Console.WriteLine($"Steward {steward}");
            Console.WriteLine($"Řidič {driver}");

            vlak.DisconnectWagon(h4);
            Console.WriteLine("\n--Po odstraneni vagonu--");
            Console.WriteLine(vlak.ToString());

            Console.WriteLine();

            Console.WriteLine(bw1.ToString());
            Console.WriteLine(nw1.ToString());
            Console.WriteLine(h1.ToString());
            Console.WriteLine(vlak.ToString());

            Train vlak2 = new Train();
            NightWagon nw2 = new NightWagon(20, 15);
            BusinessWagon bw2 = new BusinessWagon(p4, 20);
            NightWagon nw3 = new NightWagon(20, 15);
            vlak2.ConnectWagon(nw2);

            vlak2.ConnectWagon(bw2);
            vlak2.ConnectWagon(nw3);

            Console.WriteLine("\n--Parni lokomotiva--");
            Console.WriteLine(vlak2);

            ch1.ReserveChair(p3);
            ch1.ReserveChair(p2);
            Console.WriteLine("\n--Vlak 2--");
            Console.WriteLine(vlak2.ToString());
        }
    }
}
