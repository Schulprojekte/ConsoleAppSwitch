using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSwitch
{
    class Program
    {
        private static int x;
        private static char rechenZeichen;
        private static int y;

        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine ganze Zahl ein und enter.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie ein Rechenzeichen ein und enter.");
            rechenZeichen = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Geben Sie eine ganze Zahl ein und enter.");
            y = Convert.ToInt32(Console.ReadLine());

            switch (rechenZeichen)
            {
                case '+': //char immer mit Hochsemikolon
                    Console.WriteLine(x + y);
                    Console.ReadKey();
                    break; //ohne break geht die Ausführung automatisch in den nächsten case Block

                case '-':
                    Console.WriteLine(x - y);
                    Console.ReadKey();
                    break;

                case '*':
                    Console.WriteLine(x * y);
                    Console.ReadKey();
                    break;

                case '/':
                    Console.WriteLine(x / y);
                    Console.ReadKey();
                    break;

                default: //Besondere Sprungmarke für unbekannte Sprungmarken
                    Console.WriteLine("Unbekannter Operator " + rechenZeichen);
                    Console.ReadKey();
                    break;
            }
        }
    }
}