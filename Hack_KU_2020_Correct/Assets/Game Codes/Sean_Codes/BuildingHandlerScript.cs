using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHandlerScript : MonoBehaviour
{
    public BuildingHandlerScript(){}

    public float GetPrices(Building _building)
    {
      return(_building.GetBuildingprice());
    }

    public float Getpower(Building _building)
    {
      return(Building.GetBuildingpower());
    }

    public float Getpop(Building _building)
    {
      return(Building.GetBuildingpopulation());
    }

    public float Getincome(Building _building)
    {
      return(Building.GetBuildingincome());
    }

    public GameObject GetBuilding(Building _building)
    {
      return(Building.GettheBuilding());
    }
}
