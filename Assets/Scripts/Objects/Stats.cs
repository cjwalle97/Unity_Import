using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Stats")]

public class Stats : ScriptableObject
{
    [Range(1,25)]
    public int Strength;
    [Range(1, 25)]
    public int Dexterity;
    [Range(1, 25)]
    public int Constitution;
    [Range(1, 25)]
    public int Intelligence;
    [Range(1, 25)]
    public int Wisdom;
    [Range(1, 25)]
    public int Charisma;
}
