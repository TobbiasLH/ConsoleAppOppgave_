using ConsoleAppOppgave.Functions;
using System;

namespace ConsoleAppOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Meny 1 - Beregn totalkarakter, prosentandel og deling av elev basert på 3 fag");
            Console.WriteLine("Meny 2 - Sjekk om et tall er primtall eller ikke ved å bruke while og for loop");
            Console.WriteLine("Meny 3 - Kopier alle elementer av et array til et annet");
            Console.WriteLine("Meny 4 - Slett all dupliserte elementer fra en array");
            Console.WriteLine("Meny 5 - Fjern elementer fra en liste ved å bruke remove function by passing object i LINQ Query");
            Console.WriteLine("Meny 6 - Fjern elementer fra en liste ved å komme forbi startindeksen og antall elementer som skal fjernes i LINQ Query");
            Console.WriteLine("Meny 7 - Ordne de distinkte elementene i listen i stigende rekkefølge i LINQ Query");
            Console.WriteLine("Meny 8 - Les en streng gjennom tastaturet og sorter den ved å bruke boblesortering");
            Console.WriteLine("Meny 9");
            Console.WriteLine("Meny 10");
            Console.WriteLine("Avslutt 11");
            Console.WriteLine("Hei, velg en av menyene fra 1 til 10");

            value = int.Parse(Console.ReadLine());

            Console.WriteLine("Du har valgt: " + value);

            Console.ReadKey();

            int arraySize = 4;

            switch (value)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter the marks of the student in subject 1: ");

                        int marks1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the marks of the student in subject 2: ");

                        int marks2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the marks of the student in subject 3: ");

                        int marks3 = int.Parse(Console.ReadLine());

                        Console.WriteLine(TotalMarks.TotalMark(marks1, marks2, marks3));
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Enter any number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        string returlinje = CheckPrime.ChecksPrime(num);
                        Console.WriteLine(returlinje);
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine(CopyArray.CopyArrays(arraySize));
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 4:
                    try
                    {
                        int[] arr = new int[100];
                        int i;

                        //Reads size of the array
                        Console.WriteLine("Enter size of the array: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        //Reads elements in array
                        Console.WriteLine("Enter elements in the array: ");
                        for (i = 0; i < num; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        DeleteDuplicateArray.DeleteDuplicateArrays(ref num, ref arr);

                        // Print array after deleting duplicate elements
                        Console.WriteLine("\nArray elements after deleting duplicates : ");
                        for (i = 0; i < num; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }  
                       
                        Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine(RemoveItem.RemoveItems);

                        Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine(RemoveItemPassing.RemoveItemPassings);

                        Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case 7:
                    try
                    {
                        Console.WriteLine("Her er koden for meny 7:");

                        Console.ReadLine();
                        List<Item_Mast2> itemlist = ArrangeElementsAscendingOrder.ArrangeElementsAscendingOrders();

                        foreach (var item in itemlist)
                            Console.WriteLine(item);



                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message);}
                    break;
                case 8:
                    Console.WriteLine("Her er koden for meny 8:");

                    break;
                case 9:
                    Console.WriteLine("Her er koden for meny 9:");

                    break;
                case 10:
                    Console.WriteLine("Her er koden for meny 10:");

                    break;
                case 11:
                    Environment.Exit(10);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg. Velg et tall mellom 1 og 10");
                    break;

            }

            Console.ReadKey();

        }
    }
}