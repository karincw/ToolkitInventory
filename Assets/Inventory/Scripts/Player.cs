using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.Inventory
{
    public class Player : MonoBehaviour
    {
        public InventoryObject Inventory;

        private void OnTriggerEnter(Collider other)
        {
            var item = other.GetComponent<Item>();
            if(item)
            {
                Inventory.AddItem(item.item, 1);
                Destroy(other.gameObject);
            }
        }

        private void OnApplicationQuit()
        {
            Inventory.Container.Clear(); 
        }
    }
}
