using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : ScriptableObject
{
    public int start;
    private List<int> Numbers;
    
    private void ProduceNumbers()
    {
        Numbers.Add(start);
        for (int i = start; i > 0; i--)
        {
            Numbers.Add(i);
        }
    }
}
