using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class RemoveItemPassing
    {
        public static string RemoveItemPassings(string _result)
        {
            string strResult = "";
     
            try
            {
                Console.WriteLine("Her er koden for meny 6:");
                {
                    List<string> list = new List<string>();
                    list.Add("a");
                    list.Add("b");
                    list.Add("c");
                    list.Add("d");
                    list.Add("e");
                    list.Add("f");


                    var result = from y in list
                                 select y;
                    Console.Write("Here is the list of items : \n");
                    foreach (var tchar in result)
                    {
                        Console.WriteLine("Char: {0} ", tchar);
                    }

                    list.RemoveRange(1, 4);

                    var _lResult = from n in list
                                  select n;
                    Console.Write("\nHere is the list after removing the four items starting from the list : \n");
                    foreach (var removeChar in _lResult)
                    {
                        Console.WriteLine("Char: {0} ", removeChar);
                    }

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return strResult;
        }
    }
}
