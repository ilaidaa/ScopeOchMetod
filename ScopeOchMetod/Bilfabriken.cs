using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeOchMetod
{
    internal class Bilfabriken
    {
        //Skapa en global variabel i klassen Bilfabrik så att alla andra metoder kan nå variabeln. 
        //Den har i uppgift att räkna ut hur mycket tid varje slumpmässiga process tar
        //Varför static? : när vi kör OOP finns inte static men eftersom alla metoder som skrivs nedan kommer vara static måste variabeln också vara det så att metoderna når den.
        public static int time = 0;










        //Metod 1 - Basmetoden
        //Metoden som bygger bilarna genom att använda alla andra submetoder
        public static void BuildingCars()
        {
            //Fråga användaren hur många bilar hen vill skapa
            Console.Write("Skriv in antal bilar du vil skapa: ");
            //Spara användarens inmatning
            int amount = int.Parse(Console.ReadLine());
            //Design för att skapa mellanrum mellan frågan och bilarna som ska skrivas ut
            Console.WriteLine();



            //Skapa en for loop som loopar igenom antalet bilar som användaren skrivit in
            for (int i = 1; i < amount + 1; i++) //Egentligen ska det stå int i = 0; i < amount; i++
                                                 //Anledningen till att det inte gör det är att vi vill att det på rad 41 inte ska stå bil nr 0: första gången loopen körs. 
                                                 //Maskinen startar från 0 och amount får + 1 för att datorprogram´alltid börjar från index 0.
            {
                Console.WriteLine("Bil nr " + i + ": ");
                BuildUnderCar();
                BuildWheels();
                BuildEngine();
                BuildColour();
                Console.WriteLine("Tid: antal minuter för att skapa just denna bil är " + time);

                Console.WriteLine(); //Mellanrum för design

            }

            Console.ReadKey(); //För att programmet inte ska avslutas direkt

        }











        //Metod 2 - Submetod
        //Bygger slumpmässig underrede
        public static void BuildUnderCar()
        {
            int choice = Random.Shared.Next(0, 2); //Skapa en random variabel som innehåller 2 val, nämligen 0 och 1. det sista talet räknas aldrig så 2 finns ej med

            if (choice == 0) //Om slumptalet är 0 ska följande if sats köras. 
            {
                Console.WriteLine("Underrede: rostfritt underede, ");
                time += 5; //Förkortning på time = time + 5
                           //Betyder att ett rostfritt underede tar 5 minuter 
            }
            else //Om slumptalet är 1 ska följande if sats köras. 
            {
                Console.WriteLine("Underrede: underede av stål, ");
                time += 10;
            }
        }






        //Metod 3 - Submetode
        //Ger antal hjul slumpmässig 
        public static void BuildWheels()
        {
            int choice = Random.Shared.Next(0, 3); //Slumpmässig variabel som kan ge tre alternativ. Följande: 0, 1, 2 (Räkna aldrig sista talet)

            switch (choice) //När du har fler alternativ än 2 är det bättre att köra med en switch sats ist för if.
            {
                case 0: //Om Slumptalet är 0 ska följande gälla:
                    Console.WriteLine("Hjul: 4 slitna hjul, ");
                    time += 5;
                    break;
                case 1: //Om Slumptalet är 1 ska följande gälla
                    Console.WriteLine("Hjul:  4 fyrhjulsdrivna däck");
                    time += 15;
                    break;
                case 2: //Om slumptalet är 2 ska följande gälla:
                    Console.WriteLine("Hjul: 4 vinterdäck.");
                    time += 10;
                    break;
            }
        }







        //Metod 4 - Subklass
        //Bygger motor
        public static void BuildEngine()
        {
            int choice = Random.Shared.Next(0, 3); //Slumpmässigt tal som genererar 3 alternativ. Följande: 0, 1, 2 (Räkna aldrig sista talet)

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Motor: 75 hästkrafter + en åsna bakom ratten. ");
                    time += 5;
                    break;
                case 1:
                    Console.WriteLine("Motor: 170 hästkrafter. ");
                    time += 10;
                    break;
                case 2:
                    Console.WriteLine("Motor: 550 fkng hästkrafter. ");
                    time += 15;
                    break;
            }
        }








        //Metod 5 - Subklass
        //Bygger karossen
        public static void BuildColour()
        {
            int choice = Random.Shared.Next(0, 2); //Slumptal som skapar 2 alternativ. Följande: 0, 1

            if (choice == 0) //Eftersom att vi bara har två alternativ att slumpa mellan är en if sats mer passande
            {
                Console.WriteLine("Färg: Bilen är svart.");
                time += 15;
            }
            else
            {
                Console.WriteLine("Färg: Bilen är vit. ");
                time += 10;
            }
        }


    }
}
