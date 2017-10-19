using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="LootTable")]

public class LootTable : ScriptableObject
{
    public string Name;
    public List<Item> Drops;

    [Serializable]
    public class Item
    {
        public GameObject item;
        [Range(0, 1)]
        public float Dropchance;
    }
}

