using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBehavior : MonoBehaviour
{
    public int Strength = 0;
    public int Dexterity = 14;
    public int Constitution = 14;
    public int Intelligence = 10;
    public int Wisdom = 8;
    public int Charisma = 18;

    public int StrengthMod;
    public int DexterityMod;
    public int ConstitutionMod;
    public int IntelligenceMod;
    public int WisdomMod;
    public int CharismaMod;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //1 = -5 modifier
    //2-3 =  -4 modifier
    //4-5 = -3 modifier
    //6-7 = -2 modifier
    //8-9 = -1 modifier
    //10-11 = 0 modifier
    //12-13 = +1 modifier
    //14-15 = +2 modifier
    //16-17 = +3 modifier
    //18-19 = +4 modifier
    //20 = +5 modifier
    int FindModifier(int stat)
    {
        int modifier = -6;

        for(int i = stat; i >= 0; i--)
        {
            i -= 1;
            modifier += 1;
        }
        return modifier;
    }
}
