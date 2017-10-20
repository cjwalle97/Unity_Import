using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player")]

public class Player : ScriptableObject
{
    public string Name;
    public Stats stats;
    public PlayerClass playerClass;

    private int StrengthModifier { get; set; }
    private int DexterityModifier { get; set; }
    private int ConstitutionModifier { get; set; }
    private int IntelligenceModifier { get; set; }
    private int WisdomModifier { get; set; }
    private int CharismaModifier { get; set; }
}