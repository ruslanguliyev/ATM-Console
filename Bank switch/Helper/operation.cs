using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_switch.Helper
{
    public class operation
    {
        public void PulDaxili(int limitD)
        {
            Console.WriteLine("Maksimal daxil edilen mebleg 500 AZN");
            var daxilM = Console.ReadLine();

            if(Convert.ToInt32(daxilM) > limitD)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Pulunuzu geri gotutun");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (Convert.ToInt32(daxilM) < limitD)
            {
                Console.BackgroundColor= ConsoleColor.Green;
                Console.WriteLine("Mebleg balansa daxil oldu");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void PulCixarilishi(int limitC)
        {
            Console.WriteLine("Maksimal cixarish meblegi 200 AZN");
            var CixM = Console.ReadLine();

            if (Convert.ToInt32(CixM) > limitC)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Emeliyyat mumkun deyil");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if(Convert.ToInt32(CixM) <= limitC)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Xais edirik pulunuzu goturun");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

    }
}
