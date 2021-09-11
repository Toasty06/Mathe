using System;
using System.Collections;
using System.Linq;

namespace Primzahl
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Primzahl: 1");
                Console.WriteLine("Nullstellen: 2");
                Console.WriteLine("Primfaktoren: 3");
                Console.WriteLine("Quadratische Ergänzung(WIP): 4");
                switch (Console.ReadLine())
                {
                    case "2":

                        Console.WriteLine("Term: ");
                        Console.Write("y = (x^2)*");
                        String a2 = Console.ReadLine();
                        Console.Write("    +x*");
                        String b2 = Console.ReadLine();
                        Console.Write("    +");
                        String c2 = Console.ReadLine();
                        try
                        {
                            long a3 = (long)Convert.ToDouble(a2);
                            long b3 = (long)Convert.ToDouble(b2);
                            long c3 = (long)Convert.ToDouble(c2);
                            long D = (b3 * b3) - 4 * a3 * c3;       //Diskriminante
                            double WD = Math.Sqrt(D);               //Wurzel Diskriminante
                            decimal ac = 1 / (a3 * 2M);             //1. Teil
                            double acd = Convert.ToDouble(ac);
                            double x1 = Math.Round((acd * (-b3 + WD)), 3);     //2. Teil
                            double x2 = Math.Round((acd * (-b3 - WD)), 3);
                            if (D < 0)
                            {
                                Console.WriteLine("Keine Lösung");
                            }
                            else if (D == 0)
                            {
                                Console.WriteLine("Nullstelle: " + "x=" + x1);
                            }
                            else if (D > 0)
                            {
                                Console.WriteLine("Nullstellen: " + "x1=" + x1);
                                Console.WriteLine("             x2=" + x2);
                            }

                            Console.WriteLine("----------------------------");
                        }
                        catch { }
                        break;

                    case "1":
                        {
                            bool pz = true;
                            Console.WriteLine("----------------------------");


                            pz = true;
                            static int QS(int n)
                            {
                                if (n == 0)
                                    return 0;
                                else
                                    return n % 10 + QS(n / 10);
                            }

                            Console.Write("Zahl: ");
                            string i = Console.ReadLine();
                            try
                            {
                                int z = Int32.Parse(i);

                                int q = QS(z);
                                int a = z % 2; //durch 2
                                if (a == 0) { pz = false; }
                                int b = q % 3; //durch 3
                                if (b == 0) { pz = false; }
                                int c = z % 5; //durch 5
                                if (c == 0) { pz = false; }
                                int d = z % 7;
                                if (d == 0) { pz = false; }
                                if (z == 1)
                                {
                                    pz = false;
                                }

                                //console
                                if (z == 2 || z == 3 || z == 5 || z == 7 || pz == true)
                                {
                                    Console.WriteLine("Primzahl");
                                    Console.WriteLine("----------------------------");

                                }
                                else
                                {
                                    Console.WriteLine("keine Primzahl");
                                    Console.WriteLine("----------------------------");
                                }

                            }
                            catch { }
                            }
                        break;
                    case "3":
                        Console.WriteLine("----------------------------");
                        Console.Write("Zahl: ");
                        try
                        {
                            int zul = Int32.Parse(Console.ReadLine());
                            
                            foreach (int i in PFZ(zul))
                            {
                                Console.WriteLine(i);
                            }
                            String zih = Console.ReadLine();
                            try
                            {
                                long zahl = (long)Convert.ToDouble(zih);
                                int zahlint = (int)Convert.ToDouble(zih);
                            }
                            catch { }

                            Console.WriteLine("----------------------------");
                        }
                        catch { }
                        break;
                    case "4":
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Term: ");
                        Console.Write("y = (x^2)*");
                        String a4 = Console.ReadLine();
                        Console.Write("    +x*");
                        String b4 = Console.ReadLine();
                        Console.Write("    +");
                        String c4 = Console.ReadLine();
                        try
                        {
                            long a5 = (long)Convert.ToDouble(a4);
                            long b5 = (long)Convert.ToDouble(b4);
                            long c5 = (long)Convert.ToDouble(c4);
                            long klammerfaktor = 1;
                            long afkt = 1;
                            long bfkt = 1;

                            ArrayList same = new ArrayList();
                            ArrayList compare = new ArrayList();
                            
                            
                                foreach (int i in PFZ(a5))
                                {
                                    compare.Add(i);
                                }
                                if (a5 > b5)
                                {
                                foreach (int i in PFZ(b5))
                                {
                                    if (compare.Contains(i))
                                    {
                                        compare.Remove(i);
                                        same.Add(i);
                                    }
                                }
                                foreach (int o in compare)
                                {
                                    Console.WriteLine(o);
                                    afkt *= o;
                                }

                            }
                                else if (b5 > a5)
                                {
                                    foreach (int i in PFZ(b5))
                                    {
                                        compare.Add(i);
                                    }
                                    foreach (int i in PFZ(a5))
                                    {
                                        if (compare.Contains(i))
                                        {
                                            compare.Remove(i);
                                            same.Add(i);
                                        }

                                    }
                                foreach (int o in compare)
                                {
                                    Console.WriteLine(o);
                                    afkt *= o;
                                }
                            }
                            else
                            {
                                Console.WriteLine("fucked");
                            }
                            Console.WriteLine(".............");

                            foreach (int o in same)
                            {
                                klammerfaktor *= o;
                            }
                            Console.WriteLine(klammerfaktor+"*("+ afkt+"*(x^2)+"+bfkt + "*x");
                            Console.WriteLine(".............");
                            Console.WriteLine("----------------------------");
                            
                        }
                        catch { }
                        break;

                    default:
                        break;
                }

            }
        }
        public static ArrayList PFZ(long zahl)
        {
            int[] array3 = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            ArrayList Faktoren = new ArrayList();

            if (array3.Contains((int)Convert.ToDouble(zahl)))
            {
                Faktoren.Add((int)Convert.ToDouble(zahl));

            }
            else
            {
                //Zerlegen
                foreach (int i in array3)
                {
                    while (zahl % i == 0)
                    {
                        Faktoren.Add(i);
                        zahl = zahl / i;
                    }

                }
            }
            return Faktoren;
        }
    }
}