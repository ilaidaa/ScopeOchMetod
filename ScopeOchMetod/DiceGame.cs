using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeOchMetod
{
    internal class DiceGame
    {
        //Global  variabel som ska räkna poäng
        //Static för att metoderna är static

        static int point = 0;








        //Metod 1
        //Skapar EN tärning 
        public static int RollDice() //Du måste skriva int ist för void för att du returnerar en int variabel
        {
            int choice = Random.Shared.Next(0, 6); //Skapar en slumpvariabel som ska ge 6 olika alternativ: 0, 1, 2, 3, 4, 5 (det sista talet räknas aldrig men det gör inget eftersom maskinen börjar från 0)

            switch (choice) //Skriv in de 6 slumptalen 
            {
                case 0:
                    Console.WriteLine("=====");
                    Console.WriteLine("|   |");
                    Console.WriteLine("| O |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("=====");
                    break;
                case 1:
                    Console.WriteLine("=====");
                    Console.WriteLine("|O  |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|  O|");
                    Console.WriteLine("=====");
                    break;
                case 2:
                    Console.WriteLine("=====");
                    Console.WriteLine("|O  |");
                    Console.WriteLine("| O |");
                    Console.WriteLine("|  O|");
                    Console.WriteLine("=====");
                    break;
                case 3:
                    Console.WriteLine("=====");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("=====");
                    break;
                case 4:
                    Console.WriteLine("=====");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("| O |");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("=====");
                    break;
                case 5:
                    Console.WriteLine("=====");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("|O O|");
                    Console.WriteLine("=====");
                    break;
            }

            return choice; //Returnerar tärningsresultatet som ett heltal (0-5)
                           //Du returnerar alltså vilken summa tärningen som kastatdes är.
                           //Så om det slumpades fram en 3:a så returnerar du talet 3
                           //Varför? i metod 2 kan du annars inte spara RollDice som en int variabel (dice1, dice2, dice3)
                           //Du sparar en tärning (dice1) med den slumptärning som den får från denna metod och som tidigare returnerats som choice
        }



        //Metod 2
        //Anropa den första metoden som ska skriva ut tre tärningar efter varandra
        //Anropar också den sista metoden för att räkna poäng
        public static void Draw3Dice()
        {
            while (true)
            {
                Console.Clear(); //Rensa konsolen varje gång while- loopen ska köras

                //Använd slumptalet som returneras i RollDice metoden och spara den i en variabel som dice1
                int dice1 = RollDice();
                int dice2 = RollDice();
                int dice3 = RollDice();


                Console.WriteLine();// Mellanslag mellan tärningarna och poängen

                CalculatePoint(dice1, dice2, dice3);

                Console.ReadKey();
            }


        }










        //Metod 3
        //Används för att räkna ut poäng
        public static void CalculatePoint(int dice1, int dice2, int dice3)
        //Du måste också ta in dice1, dice2 och dice3 som parameter för att de deklarerades i metoden innan (Metod 2)
        {
            if (dice1 == dice2 && dice2 == dice3) //Om alla tre tärningar visar lika
            {
                point += 10; //Lägger till 10 poäng på räknar variabeln.
                             //Måste vara innan raden efter annars kan inte de 10 poängen som lägg tills räknas med i svaret som ges till användaren
                Console.WriteLine("Snyggt! Du fick tre lika, vilket blir +10 poäng.");
                Console.WriteLine("Din nuvarande poäng är: " + point);
            }
            else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3) //Om två tärningar visar lika
            {
                point += 3;
                Console.WriteLine("Snyggt! Du fick två lika, vilket blir +3 poäng.");
                Console.WriteLine("Din nuvarande poäng är: " + point);
            }
            else if (dice1 + dice2 + dice3 < 9) //Om summan av alla tärningar är mindre än 9
            {
                point -= 5;
                Console.WriteLine("Ajdå! Summan av alla tärningar är mindre än 9, vilket blir -5 poäng.");
                Console.WriteLine("Din nuvarande poäng är: " + point);
            }
            else //Om inget av ovanstående händer skrivs bara poängen ut
            {
                Console.WriteLine("Din nuvarande poäng är: " + point);
            }

        }


    }
}
