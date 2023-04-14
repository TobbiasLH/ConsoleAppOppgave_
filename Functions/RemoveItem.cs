using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
        public class RemoveItem
        {
            public static void RemoveItems()
            {
                try
                {
                    Console.WriteLine("Her er koden for meny 5:");
                    {
                        List<string> list = new List<string>();
                        list.Add("a");
                        list.Add("b");
                        list.Add("c");
                        list.Add("d");
                        list.Add("e");

                        var _result1 = from y in list
                                       select y;
                        Console.Write("Here is the list of items : \n");
                        foreach (var tchar in _result1)
                        {
                            Console.WriteLine("Char: {0} ", tchar);
                        }

                        string newstr = list.FirstOrDefault(n => n == "c");
                        list.Remove(newstr);


                        var _result = from z in list
                                      select z;
                        Console.Write("\nHere is the list after removing the item 'c' from the list : \n");
                        foreach (var c in _result)
                        {
                            Console.WriteLine("Char: {0} ", c);
                        }

                        Console.ReadLine();
                    }
                }
                catch (Exception ex) {Console.WriteLine(ex.Message);}
                
            // return _result;
            
            }
        }
}
