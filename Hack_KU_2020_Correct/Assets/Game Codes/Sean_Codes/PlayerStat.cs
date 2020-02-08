using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Sean.CharacterStats
{
[Serializable]
public class PlayerStat
{
    public float BaseValue;
    public float Value 
    {
        get {
            if (needsUpdate || BaseValue != lastBaseValue) {
                lastBaseValue = BaseValue;
                _value = CalculateFinalValue();
                needsUpdate = false;
            }
            return _value;
        }
    }

    protected bool needsUpdate = true;
    protected float _value;
    protected float lastBaseValue = float.MinValue;

    protected readonly List<StatModifier> statModifiers;
    public readonly ReadOnlyCollection<StatModifier> StatModifiers;

    public PlayerStat()
    {
        statModifiers = new List<StatModifier>();
        StatModifiers = statModifiers.AsReadOnly();
    }

    public PlayerStat(float baseValue) : this()
    {
        BaseValue = baseValue;
    }

    public virtual void AddModifier(StatModifier mod)
    {
        needsUpdate = true;
        statModifiers.Add(mod);
        statModifiers.Sort(CompareModifierOrder);
    }

    protected virtual int CompareModifierOrder(StatModifier a, StatModifier b)
    {
        if (a.Order < b.Order) {
            return -1;
        }
        else if (a.Order > b.Order) {
            return 1;
        }
        return 0;
    }
    public virtual bool RemoveModifier(StatModifier mod)
    {
        if (statModifiers.Remove(mod)){
            needsUpdate = true;
            return true;
        }
        return false;
    }

    public virtual bool RemoveAllModifiersFromSource(object source) {

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

    protected virtual float CalculateFinalValue()
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
}