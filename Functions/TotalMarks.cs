using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class TotalMarks
    {
        public static string TotalMark(int marks1, int marks2, int marks3)
        {
            string division = "Unknown Division";
            try
            {
                Console.WriteLine("Her er koden for meny 1:");
                {

                    int total;

                    float percentage;




                    total = marks1 + marks2 + marks3;



                    percentage = (total / 300) * 100;



                    if (percentage >= 60)
                    {

                        division = "First Division";

                    }
                    else if (percentage >= 45)
                    {

                        division = "Second Division";

                    }
                    else
                    {

                        division = "Third Division";

                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return division;
        }
    }
}
