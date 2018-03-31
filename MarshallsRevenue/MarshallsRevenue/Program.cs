using System;

namespace MarshallsRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Mon();
            Console.WriteLine("How many interior murals are scheduled? ");
            int i = Con();
            Console.WriteLine("How many exterior murals are scheduled? ");
            int ex = Con();
            Console.WriteLine(Price(i, ex, m, "i"));
            if (m == 12 || m == 1 || m == 2)
            {
                Console.WriteLine("There can be no exterior murals scheduled in December, January, or February\nThe exterior mural revenue will be $0.00");
            }
            else
            {
                Console.WriteLine(Price(i, ex, m, "e"));
            }
            string[] inte = Name(i, "i");
            string[] exte = Name(ex, "e");
            List(inte, exte);
        }
        public static int Mon()
        {
            Console.WriteLine("What Month will the following murals be scheudled in? (1,2,3,etc..)");
            int h;
            bool g = int.TryParse(Console.ReadLine(), out h);
            if (h >= 1 && h <= 12 && g == true)
            {
                return h;
            }
            else {
                Console.WriteLine("That was an invalid month, please reenter your data.");
                return Mon();
                    }
        }
        public static int Con()
        {
            Console.Write("Enter the number of murals: ");
            int y;
            bool t = int.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && y <= 30 && t == true)
            {
                return y;
            }
            else
            {
                Console.WriteLine("That is an invalid number of murals, please renter your data.");
                return Con();
            }
        }
        public static string Price(int x, int y, int z, string h)
        {
            int i = x;
            int ex = (y);
            int month = (z);
            double ip = 0;
            double exp = 0;
                    if (month == 12 || month == 1 || month == 2)
                    {
                        ex = 0;
                    }
                    if (month == 4 || month == 5 || month == 9 || month == 10)
                    {
                        exp = ex * 699;
                    }
                    else
                    {
                        exp = ex * 750;
                    }
                    if (month == 7 || month == 8)
                    {
                        ip = i * 450;
                    }
                    else
                    {
                        ip = i * 500;
                    }
            if (h == "i")
            {
                return "Interior Mural Revenue: " + ip.ToString("C");
            }
            if (h == "e")
            {
                return "Exterior Mural Revenue: " + exp.ToString("C");
            }
            else
            {
                return "";
            }
        }
        public static string[] Name(int x, string z)
        {
            string[] j = new string[x * 2];
            int b = 1;
            string s = "";
            for (int k = 0; k < j.Length; k+= 2)
            {
                if (z == "i")
                {
                    s = "interior murals";
                }
                else if (z=="e")
                {
                    s = "exterior murals";
                }
                Console.Write("Enter the name of buyer " + b + " for " + s + ": ");
                string h = Console.ReadLine();
                j[k] = h;
                Console.Write("Enter " + j[k] + "'s type of mural: ");
                b++;
                string m = Console.ReadLine().ToUpper();
                if (m == "C" || m == "S" || m == "L" || m == "O" || m == "A")
                {
                    j[k + 1] = m;
                }
                else
                {
                    Console.WriteLine("That was an invalid type, please reenter buyer information.");
                    k -= 2;
                }
            }
            return j;
        }
        public static void List(string[]x, string[] y)
        {
            string[] i = x;
            string[] e = y;
            string h = "";
            while (h != "EXIT")
            {
                Console.Write("Enter a mural type code to see who ordered that mural type: ");
                h = Console.ReadLine().ToUpper();
                if (h == "A" || h == "L" || h == "O" || h == "C" || h == "S")
                {
                    for (int o = 0; o < i.Length; o++)
                    {
                        if (i[o] == h)
                        {
                            Console.WriteLine(i[o - 1] + " had an interior mural scheduled of type " + h);
                        }
                    }
                    for (int z = 0; z < e.Length; z++)
                    {
                        if (e[z] == h)
                        {
                            Console.WriteLine(e[z - 1] + " had an exterior mural scheduled of type " + h);
                        }
                    }
                }
                else if (h != "EXIT")
                {
                    Console.WriteLine("You entered an invalid mural code.");
                }
            }
        }
    }
}

