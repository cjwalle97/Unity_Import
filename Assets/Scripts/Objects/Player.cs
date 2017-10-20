using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player")]

public class Player : ScriptableObject
{
    public string Name;
    public Stats stats;
    public PlayerClass playerClass;

    private int StrengthModifier;
    private int DexterityModifier;
    private int ConstitutionModifier;
    private int IntelligenceModifier;
    private int WisdomModifier;
    private int CharismaModifier;
}