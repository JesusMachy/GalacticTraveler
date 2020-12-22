using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    // Vitals
    public string Name;
    public int Level;

    // Base Attributes
    public int BaseStrength;
    public int BaseAgility;
    public int BasePerception;
    public int BaseToughness;
    public int BaseInteligence;
    public int BaseCharisma;

    public int GetStrength()
    {
        int value = this.BaseStrength;

        return value;
    }
    public int GetAgility()
    {
        int value = this.BaseAgility;

        return value;
    }
    public int GetPerception()
    {
        int value = this.BasePerception;

        return value;
    }
    public int GetToughness()
    {
        int value = this.BaseToughness;

        return value;
    }
    public int GetInteligence()
    {
        int value = this.BaseInteligence;

        return value;
    }
    public int GetCharisma()
    {
        int value = this.BaseCharisma;

        return value;
    }
}
