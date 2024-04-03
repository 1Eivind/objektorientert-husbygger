using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientert_husbygger
{
    public class Etasje
    {
        public bool hasBathroom = false;
        public bool hasKitchen = false;

        public List<string> rom = new List<string>();


        public void PrintMenu()
        {
            Console.WriteLine("Velg et rom å legge til etasjen.\n");
            Console.WriteLine("1. Legg til bad (maks ett per etasje)");
            Console.WriteLine("2. Legg til kjøkken (maks ett per etasje)");
            Console.WriteLine("3. Legg til soverom");
            Console.WriteLine("4. Legg til stue\n");
        }

        public void AddBathroom()
        {
            if (hasBathroom || hasKitchen)
            {
                Console.Write("Etasjen har allerede et bad eller kjøkken og kan bare ha ett");
            }
            else
            {
                rom.Add("bad");
                Console.WriteLine("Du har lagt til et bad");
                hasBathroom = true;
            }
        }

        public void AddBedroom()
        {
            rom.Add("Soverom");
            Console.WriteLine("Du har lagt til et soverom\n");
        }

        public void AddKitchen()
        {
            if (hasKitchen || hasBathroom)
            {
                Console.Write("Etasjen har allerede et kjøkken eller bad og kan bare ha ett");
            }
            else
            {
                rom.Add("Kjøkken");
                Console.WriteLine("Du har lagt til et kjøkken\n");
                hasKitchen = true;
            }
        }

        public void AddLivingRoom()
        {
            rom.Add("Stue");
            Console.WriteLine("Du har lagt til en stue\n");

        }
    }
}
