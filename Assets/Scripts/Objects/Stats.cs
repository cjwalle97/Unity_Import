using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Stats")]

public class Stats : ScriptableObject
{
    public int Strength;
    public int Dexterity;
    public int Constitution;
    public int Intelligence;
    public int Wisdom;
    public int Charisma;

    private int StrengthModifier;
    private int DexterityModifier;
    private int ConstitutionModifier;
    private int IntelligenceModifier;
    private int WisdomModifier;
    private int CharismaModifier;
}
