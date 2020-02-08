﻿using System.Collections.Generic;
using System;

public class PlayerStats
{
    public float BaseValue;
    public float Value 
    {
        get {
            if (needsUpdate) {
                _value = CalculateFinalValue();
                needsUpdate = false;
            }
            return _value;
        }
    }

    private bool needsUpdate = true;
    private float _value;

    private readonly List<StatModifier> statModifiers;

    public PlayerStats(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }

    public void AddModifier(StatModifier mod)
    {
        needsUpdate = true;
        statModifiers.Add(mod);
        statModifiers.Sort(CompareModifierOrder);
    }

    private int CompareModifierOrder(StatModifier a, StatModifier b)
    {
        if (a.Order < b.Order) {
            return -1;
        }
        else if (a.Order > b.Order) {
            return 1;
        }
        return 0;
    }
    public bool RemoveModifier(StatModifier mod)
    {
        needsUpdate = true;
        return(statModifiers.Remove(mod));
    }

    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;

        StatModifier mod = null;

        for (int i=0; i < statModifiers.Count; i++)
        {
            mod = statModifiers[i];

            if (mod.Type == StatModType.Flat)
            {
                finalValue += mod.Value;
            }
            else if (mod.Type == StatModType.Percent)
            {
                finalValue *= 1 + mod.Value;
            }

        }

        return (float)Math.Round(finalValue, 4);
    }
}
