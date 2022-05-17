using System;
using System.Collections.Generic;

namespace Brackey_ep5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("PortalGun");
            shoppingList.Add("GravityGun");
            shoppingList.Add("Glados");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Glados");
            shoppingList.RemoveAt(1);

            Console.WriteLine("-----------------");

             for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            // Wait before closing
            Console.ReadKey();
        }
    }
}
