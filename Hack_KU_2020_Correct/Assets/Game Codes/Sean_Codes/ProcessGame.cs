﻿//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System;
using UnityEngine;
using Sean.CharacterStats;

public class ProcessGame : MonoBehaviour
{
    public GameObject Stats;
    private handleStats _handler;
    private float _lastUpdateTime = float.MinValue;
    private bool needsUpdate = false;
    private float _income = float.MinValue;

    void Start()
    {
        _handler = Stats.GetComponent<handleStats>();
    }
    
    void Update()
    {
        if (needsUpdate)
        {
            needsUpdate = false;
            _income = _handler.getInPerMin();
            _handler.updateFunds(StatModType.Flat, (float)Math.Round(_income/3));
            _lastUpdateTime = Time.time;
        }

        if (Time.time > _lastUpdateTime + 20)
        {
            needsUpdate = true;
        }
    }

}
