using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class ReadTextFile
    {
        public static void ReadTextFiles()
        {
            try
            {
                try
                {
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReadFile.txt");

                    using (StreamReader inputFile = new StreamReader(filePath))
                    {
                        Console.WriteLine(inputFile.ReadToEnd());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error reading the file: ");
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message);}
        }
    }
}
