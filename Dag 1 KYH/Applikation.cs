using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Dag_1_KYH
{
    internal class Applikation
    {
        public void Run()
        {

            //Skapa konto
            //Ta bort konto
            //Lista alla kontonummer
            //Lista totalsaldo
            //Lista alla kontonummer och saldo

            var dict = new Dictionary<string, int>();

            bool run = true;

            while (run)
            {
                Console.WriteLine("\n1. Skapa konto\n2. Ta bort konto\n3. Lista alla kontonummer\n4. Lista totalsaldo\n5. Lista alla kontonummer och saldo\n6. Quit");
                Console.Write("Ange menyval: ");
                string menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    case "1":

                        Console.Write("Skapa ett konto\nAnvändarnamn: ");
                        string kontonummer = Console.ReadLine();

                        Console.Write("Lägg in pengar: ");
                        int pengar=int.Parse(Console.ReadLine());
                        dict[kontonummer] = pengar;

                        break;

                    case "2":

                        Console.WriteLine("Ange kontot du vill radera");
                        dict.Remove(Console.ReadLine());

                        break;

                    case "3":

                        Console.WriteLine("\nHär är dina konton:\n");
                        foreach (var key in dict.Keys)
                        {
                            Console.WriteLine(key + "\n");
                        }

                        break;

                    case "4":

                        Console.WriteLine("\nHär är dina saldon\n");
                        foreach (var key in dict.Keys)
                        {

                            Console.WriteLine(dict[key]+"\n");
                        }

                        break;

                    case "5":

                        Console.WriteLine("\nHär är dina konton respektive saldon\n");

                        foreach (var key in dict.Keys)
                        {
                            Console.WriteLine(key + "\n");
                            Console.WriteLine(dict[key] + "\n");
                        }

                        break;

                    case "6":

                        run = false;
                        Console.WriteLine("\n---------------------Tack för att du använt vårt program---------------------");

                        break;
                }
            }








            //int[] change = new int[] { 500, 200, 100, 50, 20, 10, 5, 1 };
           
            //Console.WriteLine("Hur mycket betalar du med?");
            //int betaldSumma = int.Parse(Console.ReadLine());


            //for (int i = 0; i < betaldSumma; i++)
            //{
            //    change[0]= (int)(betaldSumma / 500);
            //    betaldSumma %= 500;

            //    change[1] = (int)(betaldSumma / 200);
            //    betaldSumma %= 200;

            //    change[2] = (int)(betaldSumma / 100);
            //    betaldSumma %= 100;

            //    change[3] = (int)(betaldSumma / 50);
            //    betaldSumma %= 50;

            //    change[4] = (int)(betaldSumma / 20);
            //    betaldSumma %= 20;

            //    change[5] = (int)(betaldSumma / 10);
            //    betaldSumma %= 10;

            //    change[6] = (int)(betaldSumma / 5);
            //    betaldSumma %= 5;

            //    change[7] = (int)(betaldSumma / 1);
            //    betaldSumma %= 1;

            //    Console.WriteLine("Du ska få tillbaka: " + change[0] + " st femhundra lappar");
            //    Console.WriteLine("Du ska få tillbaka: " + change[1] + " st tvåhundra lappar");
            //    Console.WriteLine("Du ska få tillbaka: " + change[2] + " st hundra lappar");
            //    Console.WriteLine("Du ska få tillbaka: " + change[3] + " st femtio lappar");
            //    Console.WriteLine("Du ska få tillbaka: " + change[4] + " st tjugo lappar");
            //    Console.WriteLine("Du ska få tillbaka: " + change[5] + " st tio kronor");
            //    Console.WriteLine("Du ska få tillbaka: " + change[6] + " st fem kronor");
            //    Console.WriteLine("Du ska få tillbaka: " + change[7] + " st en kronor");
            //}


            //a.Låt användaren ange ett belopp som ska betalas.
            //b.Ange växel i antal 500 - lappar, 100 - lappar, ner till kronor.
            //c.Skriv detta till skärmen


            //    Console.WriteLine("Hur mycket pengar har du?");
            //    int antalKronor = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Har du rabatt?\nY/N");
            //    char str = char.Parse(Console.ReadLine());


            //    // bool rabatt;

            //    switch (str)
            //    {
            //        case 'Y':

            //            if (antalKronor >= 15 && antalKronor <= 25)
            //            {
            //                Console.WriteLine("Du kan köpa en liten hamburgare och pommes");
            //            }
            //            else if (antalKronor >= 25 && antalKronor <= 50)
            //            {
            //                Console.WriteLine("Du kan köpa en stor hamburgare och e liten pommes");
            //            }
            //            else if (antalKronor > 60 || antalKronor >= 50 && antalKronor <= 60)
            //            {
            //                Console.WriteLine("Du kan köpa en meal med dryck");
            //            }
            //            else
            //                Console.WriteLine("Du har inte råd med något på menyn");
            //            break;

            //        case 'N':

            //            if (antalKronor >= 15 && antalKronor <= 25)
            //            {
            //                Console.WriteLine("Du kan köpa en liten hamburgare");
            //            }
            //            else if (antalKronor >= 25 && antalKronor <= 50)
            //            {
            //                Console.WriteLine("Du kan köpa en stor hamburgare");
            //            }
            //            else
            //                Console.WriteLine("Du har inte råd med något på menyn");

            //            break;
            //    }

            //}

            //a.Om summan är mellan 15 och 25 och användaren inte har rabatt skriv – Du kan köpa en liten hamburgare.
            //b.Om summan är mellan 15 och 25 och användaren har rabatt skriv – Du kan köpa en liten hamburgare och en pommes frites.
            //c.Om summan är större än 25 och mindre än eller lika med 50 och användaren inte har rabatt skriv – Du kan köpa en stor hamburgare.
            //d.Om summan är större än 25 och mindre än eller lika med 50 och användaren har rabatt skriv – Du kan köpa en stor hamburgare och pommes frites.
            //e.Om summan är större än 60 eller om den är mellan 50 och 60 och användaren har rabatt skriv – Du kan köpa ett meal med dryck.


            //int jerseyNum = int.Parse(Console.ReadLine());

            //switch (jerseyNum)
            //{
            //    case 21:
            //        Console.WriteLine("Foppa");
            //        break;

            //    case 3:
            //        Console.WriteLine("Elderbrink");
            //        break;

            //    case 12:
            //        Console.WriteLine("Sundin");
            //        break;

            //    case 33:
            //        Console.WriteLine("Chrille");
            //        break;

            //    default:
            //        Console.WriteLine("Du har inte angett rätt nummer");
            //        break;

            //}



            //Console.Write("Köpa öl  simulator\n");

            //Console.WriteLine("Var är du? S/K");
            //string location = Console.ReadLine();

            //Console.WriteLine("Hur gammal är du?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hur mycket alkohol har du i blodet?");
            //float promilleHalt = float.Parse(Console.ReadLine());

            //if (age >= 18 && location == "K" && promilleHalt < 1.0f)
            //{
            //    Console.WriteLine("Du får köpa öl.");
            //}
            //else if (age >= 20 && location == "S" && promilleHalt < 1.0f)
            //{
            //    Console.WriteLine("Ja du får köpa öl");
            //}
            //else
            //    Console.WriteLine("Du får inte köpa öl.");


            //string name;
            //Console.Write("Vad heter du?: ");
            //Console.Write("Ange din ålder också");

            //name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());




            //if (name == "Stefan")      // EXPRESSION ---- om det bara är en rad efter if satsen kan du köra utan måsvingar
            //{
            //    Console.WriteLine("Du har ett fantastiskt namn");
            //    Console.WriteLine("Som sagt det är ett fantastiskt namn");
            //}
            //else if (name == "Oliver")
            //{
            //    Console.WriteLine("Oliver är ett kul namn");
            //}
            //else
            //    Console.WriteLine("Ditt namn duger väll");


            //Console.Write("Ange vilket land du bor i: ");
            //string land = Console.ReadLine();

            //if (land == "Sverige" || land == "Danmark" || land == "Norge")
            //{
            //    Console.WriteLine("Du bor i Skandinavien");
            //}
            //else
            //    Console.WriteLine("Du bor inte i Skandinavien");

            //Console.WriteLine("Ange året du är född");
            //int yearBorn = int.Parse(Console.ReadLine());

            //if (yearBorn >= 1980 && yearBorn < 1990)
            //{
            //    Console.WriteLine("Du är född på 80-talet");
            //}
            //else if (yearBorn < 2000 && yearBorn >= 1990)
            //{
            //    Console.WriteLine("Du är född på 90-talet");
            //}
            //else if (yearBorn < 1980 || yearBorn > 2000)
            //{
            //    Console.WriteLine("Du är inte född på 80 eller 90 talen");
            //}


            //Console.WriteLine("1. Pensionär eller Student\n2. Vuxen\n");
            //Console.Write("Ange (siffran) vilken kategori du tillhör: ");
            //int category = int.Parse(Console.ReadLine());

            //if (category == 1)
            //{
            //    Console.WriteLine("Din resa kostar 20 kr");
            //}
            //else if (category == 2)
            //{
            //    Console.WriteLine("Din resa kostar 30 kr");
            //}
            //else
            //    Console.WriteLine("Du har angett felaktig kategori");

            // BRA LÖSNING PÅ KLURING 
            //-------------------------------------------------------------------------------------------
            //int age;
            //Console.Write("Ange din ålder: ");

            //// medan console.readline inte ger try.parse en int, körs koden igen
            //while (!int.TryParse(Console.ReadLine(), out age))
            //{
            //    Console.WriteLine("Fel inmatning! Ange en siffra");
            //}

            //bool correctInput = age > 0;

            //if (correctInput)
            //{
            //    if (age < 18)
            //    {
            //        Console.WriteLine("Du är inte myndig");
            //    }
            //    else if (age >= 18 && age <= 65)
            //    {
            //        Console.WriteLine("Du är myndig men inte pensionär");
            //    }
            //    else if (age > 65)
            //    {
            //        Console.WriteLine("Du är pensionär");
            //    }
            //}
            //else
            //    Console.WriteLine("Du måste ange en siffra");

            //--------------------------------------------------------------------------------------------

            //Console.Write("Ange temperaturen du ser på termometern: ");
            //float temp = float.Parse(Console.ReadLine());

            //if (temp >= 37.8f && temp <= 39.5f)
            //{
            //    Console.WriteLine("Du har feber");
            //}
            //else if (temp > 39.5f)
            //{
            //    Console.WriteLine("Du bör uppsöka läkare");
            //}
            //else
            //    Console.WriteLine("Du har inte feber");

            //Console.Write("Hur många mjölkpaket finns det kvar: ");
            //int antalMjölkpaket = int.Parse(Console.ReadLine());

            //if (antalMjölkpaket < 10)
            //{
            //    Console.WriteLine("Beställ 30 paket");
            //}
            //else if (antalMjölkpaket > 10 && antalMjölkpaket < 20)
            //{
            //    Console.WriteLine("beställ 20 paket");
            //}
            //else
            //    Console.WriteLine("Du behöver inte beställa någon mjölk");

            //Console.WriteLine("Ange antal minuter");
            //int minutes = int.Parse(Console.ReadLine());

            //if (minutes > 60)
            //{
            //    int hours = minutes / 60;
            //    int restMinutes = minutes - (hours * 60);
            //    Console.WriteLine($"Hours: {hours}\nMinutes: {restMinutes}");
            //}

            //else
            //    Console.WriteLine("Du måste minst ange 60 minuter");


            //Console.WriteLine("Ange en summa så vi kan räkna ut momsen");
            //float summa = int.Parse(Console.ReadLine());

            //float moms;

            //moms = summa * 0.25f;

            //float totalen = summa + moms;

            //Console.WriteLine($"Detta är totala summan plus moms: {totalen}");


            //Console.WriteLine("Ange tal 1");
            //int tal1 = int.Parse(Console.ReadLine());

            //int tal2 = int.Parse(Console.ReadLine());

            //int summa;
            //int medelvärde;
            //int differens;

            //summa = tal1 + tal2;
            //Console.WriteLine($"Summa: {summa}");

            //medelvärde = (tal1 + tal2) / 2;
            //Console.WriteLine($"Medelvärde: {medelvärde}");

            //differens = tal1 - tal2;
            //Console.WriteLine($"Differens: {differens}");


            //Console.Write("Ange ditt födelse år: ");
            //int birthYear = Convert.ToInt32(Console.ReadLine());

            //int actualAge = 2022 - birthYear;

            //Console.WriteLine(actualAge);

            //DateOnly dateOnly = new DateOnly();


            //Console.WriteLine(dateOnly);



            //Console.WriteLine("ange tal 1");
            //int tal1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ange tal 2");
            //int tal2 = Convert.ToInt32(Console.ReadLine());

            //int summa;

            //summa = tal1 + tal2;

            //Console.WriteLine(summa);


            //Console.WriteLine("Vad heter du i förnamn?");
            //var name = Console.ReadLine();

            //Console.WriteLine("Vad heter du i efternamn?");
            //var surName = Console.ReadLine();

            //Console.WriteLine("Ditt fulla namn är: " + name + " " + surName);


            // Console.WriteLine("Du heter " + name + " och du är " + myAge + " gammal");

            //int age;

            //console.writeline("hur gammal är du?");
            //age = int.parse(console.readline());

            //age = age + 5; // age += 5;

            //console.writeline("om 5 år är du");

            //console.writeline(age);

            //console.writeline("dagar");

            //console.writeline("vad heter du?");

            //var namn = console.readline();

            //console.writeline("hej " + namn + " välkommen");

            //console.writeline("hejdå " + namn);

            //console.readline();
        }
    }
}

