using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Inventory
    {
        private List<string> itemNames = new List<string>();

        public void AddItem(string item)
        {
            itemNames.Add(item);
        }
        public void ShowItems()
        {
            foreach (string item in itemNames)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            foreach (string item in inventory2.itemNames)
            {
                inventory1.AddItem(item);
            }
            return inventory1;
        }
    }
}
