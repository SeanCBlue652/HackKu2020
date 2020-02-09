﻿//using System.Collections;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using Sean.CharacterStats;

public class handleStats : MonoBehaviour
{
    public PlayerStat Funds;
    public PlayerStat Power;
    public PlayerStat Population;
    public PlayerStat InPerMin;

    public GameObject FundStat;
    public GameObject PowerStat;
    public GameObject PopuStat;
    public GameObject IPMStat;


    
    void Start()
    {
        updateAll();
    }

    private void writeUpdatedText(PlayerStat _stat, GameObject _object, string _text)
    {
        _object.GetComponent<UpdateStatText>().updateText(_text + _stat.Value);
    }

    private void updateAll() {
        writeUpdatedText(Funds, FundStat, "Funds: ");
        writeUpdatedText(Power, PowerStat, "Power: ");
        writeUpdatedText(Population, PopuStat, "Population: ");
        writeUpdatedText(InPerMin, IPMStat, "Income Per Minute: ");
    }

    public float getInPerMin() {
        float result = InPerMin.Value;
        return result;
    }
    public float getFunds() {
        float result = Funds.Value;
        return result;
    }
    public float getPower() {
        float result = Power.Value;
        return result;
    }
    public float getPopulation() {
        float result = Population.Value;
        return result;
    }

    public ReadOnlyCollection<StatModifier> getStatModifiers(string _statName)
    {
        if (_statName == "Funds") {
            return(Funds.StatModifiers);
        }
        if (_statName == "Power") {
            return(Power.StatModifiers);
        }
        if (_statName == "Population") {
            return(Population.StatModifiers);
        }
        if (_statName == "Income") {
            return(InPerMin.StatModifiers);
        }
        print("Invalid input for getStatModifiers, returning Funds modifiers by default.");
        return(Funds.StatModifiers);
    }
    public void updateFunds(StatModType _type, float _value) {
        StatModifier _mod = new StatModifier(_value, _type);
        Funds.AddModifier(_mod);
        updateAll();
    }
    public void updateFunds(StatModType _type, float _value, GameObject _source) {
        StatModifier _mod = new StatModifier(_value, _type, _source);
        Funds.AddModifier(_mod);
        updateAll();
    }
    public void updatePower(StatModType _type, float _value) {
        StatModifier _mod = new StatModifier(_value, _type);
        Power.AddModifier(_mod);
        updateAll();
    }
    public void updatePower(StatModType _type, float _value, GameObject _source) {
        StatModifier _mod = new StatModifier(_value, _type, _source);
        Power.AddModifier(_mod);
        updateAll();
    }
    public void updatePopulation(StatModType _type, float _value) {
        StatModifier _mod = new StatModifier(_value, _type);
        Population.AddModifier(_mod);
        updateAll();
    }
    public void updatePopulation(StatModType _type, float _value, GameObject _source) {
        StatModifier _mod = new StatModifier(_value, _type, _source);
        Population.AddModifier(_mod);
        updateAll();
    }
    public void updateIPM(StatModType _type, float _value) {
        StatModifier _mod = new StatModifier(_value, _type);
        InPerMin.AddModifier(_mod);
        updateAll();
    }
    public void updateIPM(StatModType _type, float _value, GameObject _source) {
        StatModifier _mod = new StatModifier(_value, _type, _source);
        InPerMin.AddModifier(_mod);
        updateAll();
    }
}
