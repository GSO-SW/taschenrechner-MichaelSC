using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            int auswahl;
            int ergebnis = 0;
            string zeichen="";

            Console.WriteLine("Bitte wählen sie ein rechen zeichen aus.");
            Console.WriteLine("1.+");
            auswahl = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("\nZahl 1: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (auswahl)
            {
                case 1:
                    ergebnis = zahl1 + zahl2;
                    zeichen = "+";
                    break;
                default:
                    break;
            }


            Console.WriteLine(zahl1 + zeichen + zahl2 + " = " + ergebnis);

            Console.ReadLine();

         
        }
    }
}
