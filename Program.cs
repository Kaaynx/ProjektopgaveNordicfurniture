using System;
using System.Security.Cryptography.X509Certificates;

namespace ProjektopgaveNordicfurniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.1: - Eksempel på vødvendige variabler og datatyper
            Console.WriteLine("Variabler og datatyper");
            Console.WriteLine();

            //Eksempler på variabler og datatyper
            //medarbejderNavn, medarbejderID, alder, afdeling/by, løn, fastansat? (bool), ansættelsesdato, feriedage, sygedage

            string medarbejderNavn = "Anders";
            string medarbejderID = "NF001";
            int alder = 32;
            string afdeling = "Produktion";
            string by = "Randers";
            double timeloen = 360.5;
            bool fastansat = true;
            DateTime ansatDato = new DateTime(2025, 9, 30);
            string feriedage = "35";
            string feriedageTilbage = "12";
            string sygedage = "20";

            Console.WriteLine($"Medarbejder: {medarbejderNavn}");
            Console.WriteLine($"Medarbejder-ID: {medarbejderID}");
            Console.WriteLine($"Alder: {alder} år");
            Console.WriteLine($"Afdeling: {afdeling}");
            Console.WriteLine($"Lokation: {by}");
            Console.WriteLine($"Timeløn: {timeloen} kr.");
            Console.WriteLine($"Ansat dato: {ansatDato.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Fastansat: {(fastansat ? "Ja" : "Nej")}");
            Console.WriteLine($"Feriedage i år: {feriedage}");
            Console.WriteLine($"Resterende feriedage: {feriedageTilbage}");
            Console.WriteLine($"Sygedage i år: {sygedage}");

            Console.WriteLine();

            // Del 2.2: - ARRAYs
            Console.WriteLine("=== Del 2.2: Array med medarbejdernavne");
            Console.WriteLine();

            //Oprettelse af string array med plads til 10 medarbejder navne
            string[] NordicMedarbejdere = new string[10];

            //Udfyldelse af navne
            NordicMedarbejdere[0] = "Anders";
            NordicMedarbejdere[1] = "Kasper";
            NordicMedarbejdere[2] = "Jonas";
            NordicMedarbejdere[3] = "Birgitte";
            NordicMedarbejdere[4] = "Sasha";

            //for loop til udskrivelse af navne
            Console.WriteLine("Medarbejdere i Nordic furniture:");
            for (int i = 0; i < NordicMedarbejdere.Length; i++)
            {
                if (NordicMedarbejdere[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {NordicMedarbejdere[i]}");
                }
                else
                {
                    Console.WriteLine($"{i + 1} [Mangler navn]");
                }
            }

            Console.WriteLine();

            //Foreach (for sjov)
            /*
             * int nummer = 1;
             * foreach (var medarbejder in NordicMedarbejdere)
             * {
             *      if (medarbejder != null)
             *      {
             *          Console.WriteLine($"{nummer}. {medarbejder}");
             *      }
             *      else
             *      {
             *          Console.WriteLine($"{nummer}. [Mangler medarbejder]");
             *      }
             *      nummer++;
             * }
             */

        

            //Opgave 2.3 - List<string>

            
            List<string> medarbejderIDliste = new List<string>();
            myAddToList("NF001");
            myAddToList("NF002");
            myAddToList("NF003");
            myAddToList("NF004");
            myAddToList("NF005");


            Console.WriteLine("Alle medarbejder-ID'er:");
            string IDnummer = "IDnummer";
            void PrintListe()
            {

                foreach (var medarbejderID in medarbejderIDliste)
                {
                    Console.WriteLine($"{IDnummer}. {medarbejderID}");
                }
            }

            Console.WriteLine("Indtast ID til listen");
            string AddId = Console.ReadLine();

            myAddToList(AddId);

            void myAddToList(string ID)
            {
                medarbejderIDliste.Add(ID);
               
            }

            Console.WriteLine();

            Console.WriteLine("Indtast ID der skal fjernes fra listen");
            string RemoveId = Console.ReadLine();

            myRemoveFromList(RemoveId);

            void myRemoveFromList(string ID)
            {
                medarbejderIDliste.Remove(ID);
            }

            Console.WriteLine();

            //var = den tjekker selv efter hvilket varible type det er modsat int som deklerare at det er en int.
            //var automatisk kan finde variblen, og derfor er mere generel i fx en loop. 
            //var = varible

            Console.WriteLine("Indtast ID der skal tjekkes fra listen");
            string TjekId = Console.ReadLine();

            // Tjek om ID'et findes
            bool findes = TjekIDInList(TjekId);

            Console.WriteLine();

            // Udskriv resultat
            if (findes)
            {
                Console.WriteLine($"ID '{TjekId}' blev fundet i listen!");
            }
            else
            {
                Console.WriteLine($"ID '{TjekId}' blev IKKE fundet i listen.");
            }

            bool TjekIDInList(string ID)
            {
                var result = medarbejderIDliste.Contains(ID);
                if (result == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Komplet liste over medarbejder IDer");
            Console.WriteLine();

            PrintListe();

            Console.ReadKey();
            // metoder er defineret af: visibility (private, internal, public),
            // variabletype (int, void, bool, string, List),
            // Et navn på metoden (WhateverTheFuck),
            // Parameter, hvilke ting skal din metode modtage (int tal, string navn)

            // f.eks. 
            //void Ugabuga(int tal1)
            //{

            //}

            //int PlusMetode(int tal1, int tal2)
            //{
            //    return tal1 + tal2;
            //}

        }
    }
}
