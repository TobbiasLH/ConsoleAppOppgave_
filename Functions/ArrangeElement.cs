using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class ArrangeElement
    {
        public static void ArrangeElements(int num)
        {
            try
            {
                Console.WriteLine("Her er koden for meny 7:");

                var itemlist = (from c in Item_Mast.Getitem()
                                select c.ItemDes)
                            .Distinct()
                            .OrderBy(x => x);

                foreach (var item in itemlist)
                    Console.WriteLine(item);
                Console.ReadLine();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString()); 
            }
        }
    }

    class Item_Mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast> Getitem()
        {
            List<Item_Mast> list = new List<Item_Mast>();
            list.Add(new Item_Mast() { ItemId = 1, ItemDes = "AUDI" });
            list.Add(new Item_Mast() { ItemId = 2, ItemDes = "BMW" });
            list.Add(new Item_Mast() { ItemId = 3, ItemDes = "BUGATTI" });
            list.Add(new Item_Mast() { ItemId = 4, ItemDes = "HONDA" });
            list.Add(new Item_Mast() { ItemId = 6, ItemDes = "FERRARI" });
            list.Add(new Item_Mast() { ItemId = 6, ItemDes = "AUDI" });
            list.Add(new Item_Mast() { ItemId = 5, ItemDes = "JAGUAR" });
            list.Add(new Item_Mast() { ItemId = 6, ItemDes = "FERRARI" });
            return list;
        }
    }
}
        