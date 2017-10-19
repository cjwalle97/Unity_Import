using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player")]

public class Player : ScriptableObject
{
    public string Name;
    public Stats stats;
    public PlayerClass playerClass;
}
