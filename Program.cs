using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Program {
        public static void Main(string[] args) {

            Person ridic = new Person("Karel", "Novák");
            Person driver = (ridic);
            Console.WriteLine("Řidič: " + driver.ToString());

            Person p1 = new Person("Jan", "Novák");
            Person p2 = new Person("Petr", "Svoboda");
            Console.WriteLine("Cestující: " + p1.ToString());
            Engine engineDiesel = new Engine(Engine.Type.Diesel);
            Console.WriteLine("Motor: " + engineDiesel.ToString());


            Locomotive locomotive1 = new Locomotive();
            Locomotive locomotive2 = new Locomotive(driver, engineDiesel);
            Locomotive locomotive3 = new Locomotive(new Person("Karel", "Novak 2"), new Engine(Engine.Type.Diesel));
            Console.WriteLine("\n--Lokomotiva ToString--");
            Console.WriteLine(locomotive2.ToString());


            Person steward = new Person("Lenka", "Kozáková");
            Console.WriteLine("\n--Vypis business vagon ToString--");
            BusinessWagon bw1 = new BusinessWagon(steward, 20);
            Console.WriteLine(bw1.ToString());
            BusinessWagon bw2 = new BusinessWagon();
            Console.WriteLine($"\nBusiness vagon default konstruktor bez prirazeni stevarda\n{bw2.ToString()}");

            Console.WriteLine("\n--Vypis Economy wagon ToString--");
            EconomyWagon ew1 = new EconomyWagon();
            Console.WriteLine(ew1.ToString());

            Console.WriteLine("\n--Vypis Night vagon ToString--");
            NightWagon nw1 = new NightWagon(20, 8);
            Console.WriteLine(nw1.ToString());

            Chair ch1 = new Chair(1);


            Console.WriteLine("-----");
            ch1.ReserveChair(p2);
            ch1.ReserveChair(p1);

            Bed b1 = new Bed(1, true);

            Hopper h1 = new Hopper(18);
            Console.WriteLine("--Hopper ToString--");
            Console.WriteLine(h1.ToString());

            Console.WriteLine("\n--Train ToString--");
            Train vlak = new Train(locomotive2);
            vlak.ConnectWagon(bw1); vlak.ConnectWagon(nw1); vlak.ConnectWagon(h1);
            Console.WriteLine(vlak.ToString());




            //Person steward = (p1);
            //Person p4 = new Person("1", "Novy");

            //BusinessWagon bw1 = new BusinessWagon(p3,20);

            //NightWagon nw1 = new NightWagon(5, 10);
            //Hopper h1 = new Hopper(150);
            //Hopper h2 = new Hopper(150);
            //Hopper h3 = new Hopper(150);
            //Hopper h4 = new Hopper(150);
            //Console.WriteLine(bw1.ToString());

            //Train vlak = new Train();
            //vlak.ConnectWagon(bw1);
            //vlak.ConnectWagon(nw1);
            //vlak.ConnectWagon(h1);
            //Console.WriteLine(vlak.ToString());
            //Console.WriteLine(e1.ToString());

            //vlak.ConnectWagon(h2);
            //vlak.ConnectWagon(h3);
            //vlak.ConnectWagon(h4);

            //vlak.DisconnectWagon(h4);
            //Console.WriteLine("\n--Po odstraneni vagonu--");
            //Console.WriteLine(vlak.ToString());

            //Console.WriteLine();

            //Console.WriteLine(bw1.ToString());
            //Console.WriteLine(nw1.ToString());
            //Console.WriteLine(h1.ToString());
            //Console.WriteLine(vlak.ToString());

            //Train vlak2 = new Train();
            //NightWagon nw2 = new NightWagon(20, 15);
            //BusinessWagon bw2 = new BusinessWagon(p4, 20);
            //NightWagon nw3 = new NightWagon(20, 15);
            //vlak2.ConnectWagon(nw2);

            //vlak2.ConnectWagon(bw2);
            //vlak2.ConnectWagon(nw3);

            //Console.WriteLine("\n--Parni lokomotiva--");
            //Console.WriteLine(vlak2);

            //ch1.ReserveChair(p3);
            //ch1.ReserveChair(p2);
            //Console.WriteLine("\n--Vlak 2--");
            //Console.WriteLine(vlak2.ToString());
        }
    }
}
