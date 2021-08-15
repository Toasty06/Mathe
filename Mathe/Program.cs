using System;

namespace Primzahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;

            while (o == 0)
            {
                Console.WriteLine("Primzahl: 1");
                Console.WriteLine("Nullstellen: 2");
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
                                Console.WriteLine(o);
                                Console.WriteLine("Primzahl");
                                Console.WriteLine("----------------------------");

                            }
                            else
                            {
                                Console.WriteLine(o);
                                Console.WriteLine("keine Primzahl");
                                Console.WriteLine("----------------------------");
                            }

                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}