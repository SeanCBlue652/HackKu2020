﻿///using System.Collections;
///using System.Collections.Generic;
//using UnityEngine;
namespace Sean.CharacterStats
{
    public enum StatModType
    {
        Flat = 100,
        PercentAdd = 200,
        PercentMult = 300,
    }

    public class StatModifier
    {
        public readonly float Value;
        public readonly StatModType Type;
        public readonly int Order;
        public readonly object Source;

        public StatModifier(float value, StatModType type, int order, object source)
        {
            Value = value;
            Type = type;
            Order = order;
            Source = source;
        }

        public StatModifier(float value, StatModType type) : this(value, type, (int)type, null) { }

        public StatModifier(float value, StatModType type, int order) : this(value, type, order, null) { }

        public StatModifier(float value, StatModType type, object source) : this(value, type, (int)type, source) { }

        public string ModToString()
        {
            string output = "Mod";
            if (Source == null)
            {
                output += ":";
            }
            else
            {
                output += " ";
                output += Source.ToString();
            }
            output += "\nValue: " + Value.ToString() + "\nType: ";
            if (Type == StatModType.Flat)
            {
                output += "Flat";
            }
            if (Type == StatModType.PercentAdd)
            {
                output += "PercentAdd";
            }
            if (Type == StatModType.PercentMult)
            {
                output += "PercentMult";
            }
            output += "\n";
            return (output);
        }
    }
}