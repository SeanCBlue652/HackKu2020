using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Building
{
    private float buildingPrice = float.MinValue;
    private float buildingPower = float.MinValue;
    private float buildingPopulation = float.MinValue;
    private float buildingIncome = float.MinValue;
    private GameObject theBuilding = null;

    private handleStats _stats;

    public Building() { }

    public Building(GameObject Buldingpath, float Bprice, float Bpower, float Bpop, float Bincome, GameObject _handleStats)
    {
        theBuilding = Buldingpath;
        buildingPrice = Bprice;
        buildingPower = Bpower;
        buildingPopulation = Bpop;
        buildingIncome = Bincome;
        _stats = _handleStats.GetComponent<handleStats>();
    }

    ~Building()
    {
      _stats.removeAllModsFromSource(theBuilding);
    }


    public float GetBuildingprice()
    {
        return (buildingPrice);
    }

    public float GetBuildingpower()
    {
        return (buildingPower);
    }

    public float GetBuildingpopulation()
    {
        return (buildingPopulation);
    }

    public float GetBuildingincome()
    {
        return (buildingIncome);
    }

    public GameObject GettheBuilding()
    {
        return (theBuilding);
    }

}
