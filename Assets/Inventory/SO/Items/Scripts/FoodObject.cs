using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.Inventory
{
    [CreateAssetMenu(menuName = "Karin/InventorySystem/Item/Food")]
    public class FoodObject : ItemObject
    {
        public int restoreHealthValue;
        private void Awake()
        {
            type = ItemType.FOOD;
        }
    }
}
