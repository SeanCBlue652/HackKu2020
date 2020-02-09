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
    public Text GainTxtBox;
    public Text LossTxtBox;
    public Text NetTxtBox;

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

    
    private float powerGain = 0;
    private float powerLoss = 0;

    // Start is called before the first frame update
    void Start()
    {
        //PowerStatHandler = GameObject.Find("StatsHandler");
        Camden = PowerStatHandler.GetComponent<handleStats>();
        Camden.updatePower(StatModType.Flat, 1f);
        Camden.updatePower(StatModType.Flat, 2f);
        Camden.updatePower(StatModType.Flat, 3f);
        Camden.updatePower(StatModType.Flat, -4f);
        _mods = Camden.getStatModifiers("Power");
        for (int i = 0; i < _mods.Count; i++)
        {
            if(_mods[i].Value >= 0)
            {
                powerGain += _mods[i].Value;
            }
            if(_mods[i].Value <= 0)
            {
                powerLoss += _mods[i].Value;
            }
        }
        updateText();
    }
    
    void awake()
    {
        NetTxtBox = GetComponent<Text>();
    }
    public void updateText()
    {
        //textBox.text = getModifierText();
        GainTxtBox.text = powerGain.ToString();
        LossTxtBox.text = powerLoss.ToString();
        NetTxtBox.text = Camden.getPower().ToString();
    }

}
