using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{

    partial class Freezer
    {
        private string brand;            
        private int capL;       
        private double temp;       
        private bool isOn;
        private DateTime manuDate;

        private static int total = 0; // Кількість створених обʼєктів
        private static double maxtemp = -18.0; // Макс. допустима температура
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];

            freezers[0] = new Freezer();
            freezers[1] = new Freezer("LG", 180);
            freezers[2] = new Freezer("Bosch", 220, new DateTime(2022, 11, 1), true);
            freezers[3] = new Freezer("Whirlpool", 195, new DateTime(2019, 7, 20), false);
            freezers[4] = new Freezer("Electrolux", 210, new DateTime(2023, 2, 15), true);

            foreach (Freezer freezer in freezers)
            {
                Console.WriteLine(freezer.ToString());
            }
        }
    }
}
