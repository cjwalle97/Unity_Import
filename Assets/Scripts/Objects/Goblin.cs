using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Goblin")]

public class Goblin : ScriptableObject
{
    public string Name;
    public int Health;
    public LootTable LootDrops;
    public Stats stats;
}
