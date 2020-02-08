using System.Collections.Generic;
using System;

public class PlayerStat
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

    public PlayerStat(float baseValue)
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
        if (statModifiers.Remove(mod)){
            needsUpdate = true;
            return true;
        }
        return false;
    }

    public bool RemoveAllModifiersFromSource(object source) {

        bool removed = false;

        for (int i = statModifiers.Count - 1; i >= 0; i--) {
            if (statModifiers[i].Source == source)
            {
                needsUpdate = true;
                removed = true;
                statModifiers.RemoveAt(i);
            }
        }

        return removed;
    }

    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;
        float sumPercentAdd = 0;

        StatModifier mod = null;

        for (int i=0; i < statModifiers.Count; i++)
        {
            mod = statModifiers[i];

            if (mod.Type == StatModType.Flat)
            {
                finalValue += mod.Value;
            }
            else if (mod.Type == StatModType.PercentAdd)
            {
                sumPercentAdd += mod.Value;

                if (i + 1 >= statModifiers.Count || statModifiers[i+1].Type != StatModType.PercentAdd) {
                    finalValue *= 1 + sumPercentAdd;
                    sumPercentAdd = 0;
                }
            }
            else if (mod.Type == StatModType.PercentMult)
            {
                finalValue *= 1 + mod.Value;
            }

        }

        return (float)Math.Round(finalValue, 4);
    }
}
