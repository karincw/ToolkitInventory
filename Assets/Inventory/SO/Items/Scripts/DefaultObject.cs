using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.Inventory
{
    [CreateAssetMenu(menuName = "Karin/InventorySystem/Item/Default")]
    public class DefaultObject : ItemObject
    {
        private void Awake()
        {
            type = ItemType.DEFAULT;
        }
    }
}
