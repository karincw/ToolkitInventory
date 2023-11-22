using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.Inventory
{
    [CreateAssetMenu(menuName = "Karin/InventorySystem/Item/Equipment")]
    public class EquipmentObject : ItemObject
    {
        public float atkBonus;
        public float defenceBonus;
        private void Awake()
        {
            type = ItemType.EQUIPMENT;
        }
    }
}
