using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public enum BuildingType
    {
        Road_Straight,
        Road_Cross,
        Road_Tee,
        Road_Corner,
        House,
        House_Alt,
        Skyscraper,
        Coal_Power,
        Power_Line,
        Warehouse,
        Watertower,
        Appartment,
    }
public class BuildingHandlerScript : MonoBehaviour
{

    public GameObject PlacementObject;
    private mousemanager placementManager;
    private readonly List<Building> _buildingList;
    public readonly ReadOnlyCollection<Building> BuildingList;

    public BuildingHandlerScript()
    {
        _buildingList = new List<Building>();
        BuildingList = _buildingList.AsReadOnly();
        placementManager = PlacementObject.GetComponent<mousemanager>();
    }

    private void updateCurrentPlacementBuilding(GameObject _object){
        placementManager.setspawnthing(_object);
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

public void shopCheckout()

}
