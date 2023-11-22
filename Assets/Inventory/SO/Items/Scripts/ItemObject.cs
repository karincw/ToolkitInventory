using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Karin.Inventory
{
    public enum ItemType
    {
        FOOD,
        EQUIPMENT,
        DEFAULT
    }

    public abstract class ItemObject : ScriptableObject
    {
        public GameObject prefab;
        public ItemType type;
        [TextArea(15, 20)] public string description;

    }
}
