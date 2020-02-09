using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;
using Sean.CharacterStats;
using UnityEngine.UI;
using System;

public class PowerMenuStatHandler : MonoBehaviour
{
    public GameObject PowerStatHandler;
    private handleStats Camden;
    public Text textBox;

    private ReadOnlyCollection<StatModifier> _mods;

    private string getModifierText()
    {
        string output = "";
        foreach (StatModifier i in _mods)
        {
            output += i.ModToString();
        }
        return output;
    }

    
    private float power_Gain = 0;

    // Start is called before the first frame update
    void Start()
    {
        //PowerStatHandler = GameObject.Find("StatsHandler");
        Camden = PowerStatHandler.GetComponent<handleStats>();
        Camden.updatePower(StatModType.Flat, 1f);
        Camden.updatePower(StatModType.Flat, 2f);
        _mods = Camden.getStatModifiers("Power");
        for (int i = 0; i < _mods.Count; i++)
        {
            
        }
        updateText();
    }
    
    void awake()
    {
        textBox = GetComponent<Text>();
    }
    public void updateText()
    {
        //textBox.text = getModifierText();
        textBox.text = Camden.getPower().ToString();
    }

}
