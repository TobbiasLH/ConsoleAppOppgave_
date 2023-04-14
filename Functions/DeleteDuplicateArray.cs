using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class DeleteDuplicateArray
    {
        public static int DeleteDuplicateArrays(ref int num, ref int[] arr)
        {
            try
            {
                Console.WriteLine("Her er koden for meny 4:");
                {
                    
                    // Total number of elements in array
                    int i, j, k;

                    // Finding all duplicate elements in array

                    for (i = 0; i < num; i++)
                    {
                        for (j = i + 1; j < num; j++)
                        {
                            //If any duplicate found */
                            if (arr[i] == arr[j])
                            {
                                // Delete the current duplicate element
                                for (k = j; k < num; k++)
                                {
                                    arr[k] = arr[k + 1];
                                }

                                //Decrement size after removing duplicate element
                                num--;

                                // If shifting of elements occur then don't increment j
                                j--;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }

            return num;
        }
    }
}
