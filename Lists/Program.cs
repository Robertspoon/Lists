using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists");

            string[] inv1 = new string[8];
            inv1[0] = ("Health Potion");
            inv1[1] = ("Shield Potion");
            inv1[2] = ("");
            inv1[3] = ("");
            inv1[4] = ("");
            inv1[5] = ("");
            inv1[6] = ("");
            inv1[7] = ("");

            for(int i = 0; i< inv1.Length; i++)
            {
                Console.WriteLine(i + " " + inv1[i]);
            }

            List<string> inv2 = new List<string>();
            inv2.Add("Health Potion");
            inv2.Add("Dabloons");
            inv2.Add("Sword");
            inv2.Add("Map");


            foreach (string item in inv2)
            {
                Console.WriteLine("- " + item);     
            }
            Console.WriteLine();

            inv2.Remove("Sword");

            foreach (string item in inv2)
            {
                Console.WriteLine("- " + item);
            }

            Console.ReadKey(true);
        }
    }
}
