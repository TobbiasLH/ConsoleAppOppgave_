using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class CheckPrime
    {
        public static string ChecksPrime(int num)
        {
            string returnvalue = "";
            try
            {
                Console.WriteLine("Her er koden for meny 2:");
                {
                    int i, f;

                    /*Reading number      
                    */

                    

                    f = 0;
                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            f = 1;
                            break;
                        }
                    }
                    
                    if (f == 0)
                        returnvalue = (num + " is a Prime Number");
                    else
                        returnvalue = (num + " is a Not Prime Number");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return returnvalue;
        }
    }
}
