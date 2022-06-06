using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellStats : MonoBehaviour
{
    public int manaCost;
    public void OnCast()
    {
        ManaTracker.instance.RemoveMana(manaCost);
    }
}
