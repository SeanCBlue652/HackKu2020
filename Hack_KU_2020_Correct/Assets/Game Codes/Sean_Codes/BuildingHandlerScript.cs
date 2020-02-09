using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class BuildingHandlerScript : MonoBehaviour
{

    private readonly List<Building> _buildingList;
    public readonly ReadOnlyCollection<Building> BuildingList;

    public BuildingHandlerScript()
    {
        _buildingList = new List<Building>();
        BuildingList = _buildingList.AsReadOnly();
    }

public float GetPrices(Building _building)
{
    return (_building.GetBuildingprice());
}

public float GetPower(Building _building)
{
    return (_building.GetBuildingpower());
}

public float GetPop(Building _building)
{
    return (_building.GetBuildingpopulation());
}

public float GetIncome(Building _building)
{
    return (_building.GetBuildingincome());
}

public GameObject GetBuilding(Building _building)
{
    return (_building.GettheBuilding());
}

public void addBuilding(Building _building) {
    _buildingList.Add(_building);
}


}
