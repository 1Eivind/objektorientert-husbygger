// See https://aka.ms/new-console-template for more information

/*Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom. Brukeren skal kunne velge hva slags type rom den
vil legge til om det er bad, kjøkken, soverom eller stue. Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom,
og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje. Når huset er ferdig, skal applikasjonen printe ut informasjon
om hvilke rom huset består av.*/

using Objektorientert_husbygger;

Console.WriteLine("Velkommen til husbygger!");
Console.WriteLine("");

Hus hus = new Hus();

Etasje førsteetasje = new Etasje();

do
{
    førsteetasje.PrintMenu();

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        førsteetasje.AddBathroom();
    }

    if (choice == "2")
    {
        førsteetasje.AddKitchen();
    }
    if (choice == "3")
    {
        førsteetasje.AddBedroom();
    }

    if (choice == "4")
    {
        førsteetasje.AddLivingRoom();
    }

    if (choice != "1" && choice != "1" && choice != "3" && choice != "4")
    {
        Console.WriteLine("Ugyldig svar. Skiv et tall fra 1-4.");
    }
}
while (førsteetasje.rom.Count < 5);

Console.WriteLine("Første etasje er ferdig. Ønsker du flere etasjer? (j/n)");
string svar = Console.ReadLine();

if (svar != "j" && svar != "n")
{
    do
    {
        Console.WriteLine("Ugyldig svar. Skriv j eller n.");
        svar = Console.ReadLine();
    } while (svar != "j" && svar != "n");

}

if (svar == "n")
{
    Console.WriteLine($"Huset er ferdig og har {hus.Etasjer} etasjer. Første etasje har følgende fem rom:");

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i + 1 + ". " + førsteetasje.rom[i] + " ");
    }
}

if (svar == "j") {

    hus.Etasjer++; 
    Etasje andreetasje = new Etasje();

        do
        {
            andreetasje.PrintMenu();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                andreetasje.AddBathroom();
            }

            if (choice == "2")
            {
                andreetasje.AddKitchen();
            }
            if (choice == "3")
            {
                andreetasje.AddBedroom();
            }

            if (choice == "4")
            {
                andreetasje.AddLivingRoom();
            }

            if (choice != "1" && choice != "1" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Ugyldig svar. Skiv et tall fra 1-4.");
            }

        } while (andreetasje.rom.Count < 5);

        Console.WriteLine("Etasjen er ferdig. Ønsker du flere etasjer? (j/n)");
        string svar2 = Console.ReadLine();

        if (svar2 != "j" && svar != "n")
        {
            do
            {
                Console.WriteLine("Ugyldig svar. Skriv j eller n.");
                svar2 = Console.ReadLine();
            } while (svar2 != "j" && svar != "n");

        }

    if (svar2 == "n")
    {
            Console.WriteLine($"Huset er ferdig med {hus.Etasjer} etasjer. Første etasje har følgende fem rom:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". " + førsteetasje.rom[i] + " \n");
            }
            Console.WriteLine("Andre etasje har følgende fem rom:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". " + andreetasje.rom[i] + " \n");
            }
    }

    if (svar2 == "j")
    {
            hus.Etasjer++;
            Etasje tredjeetasje = new Etasje();

            do
            {
                tredjeetasje.PrintMenu();

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    tredjeetasje.AddBathroom();
                }

                if (choice == "2")
                {
                    tredjeetasje.AddKitchen();
                }
                if (choice == "3")
                {
                    tredjeetasje.AddBedroom();
                }

                if (choice == "4")
                {
                    tredjeetasje.AddLivingRoom();
                }

                if (choice != "1" && choice != "1" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Ugyldig svar. Skiv et tall fra 1-4.");
                }

            } while (tredjeetasje.rom.Count < 5);

            Console.WriteLine($"Etasjen er ferdig og huset er ferdig med {hus.Etasjer} etasjer");
            Console.WriteLine("Første etasje har følgende fem rom:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". " + førsteetasje.rom[i] + " \n");
            }

            Console.WriteLine("Andre etasje har følgende fem rom:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". " + andreetasje.rom[i] + " \n");
            }

            Console.WriteLine("Tredje etasje har følgende fem rom:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". " + tredjeetasje.rom[i] + " \n");
            }
    }

}

