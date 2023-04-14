using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOppgave.Functions
{
    public class ArrangeElementsAscendingOrder
    {
        public static List<Item_Mast2> ArrangeElementsAscendingOrders()
        {
            List<Item_Mast2> itemlist = new List<Item_Mast2>();

            try
            {
                           
             itemlist = (List<Item_Mast2>)(from c in Item_Mast2.Getitem()
                            select c.ItemDes)
                       .Distinct()
                       .OrderBy(x => x);

                                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return itemlist;

        }  
    }
        public class Item_Mast2
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast2> Getitem()
        {
            List<Item_Mast2> list = new List<Item_Mast2>();
            list.Add(new Item_Mast2() { ItemId = 1, ItemDes = "AUDI" });
            list.Add(new Item_Mast2() { ItemId = 2, ItemDes = "BMW" });
            list.Add(new Item_Mast2() { ItemId = 3, ItemDes = "BUGATTI" });
            list.Add(new Item_Mast2() { ItemId = 4, ItemDes = "HONDA" });
            list.Add(new Item_Mast2() { ItemId = 6, ItemDes = "FERRARI" });
            list.Add(new Item_Mast2() { ItemId = 6, ItemDes = "AUDI" });
            list.Add(new Item_Mast2() { ItemId = 5, ItemDes = "JAGUAR" });
            list.Add(new Item_Mast2() { ItemId = 6, ItemDes = "FERRARI" });
            return list;
        }
    }
}


