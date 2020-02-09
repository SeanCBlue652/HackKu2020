using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHandlerScript : MonoBehaviour
{
    public BuildingHandlerScript(){}

    public float GetPrices(Building.building)
    {
      return(Building.GetBuildingprice());
    }

    public float Getpower(Building.building)
    {
      return(Building.GetBuildingpower());
    }

    public float Getpop(Building.building)
    {
      return(Building.GetBuildingpopulation());
    }

    public float Getincome(Building.building)
    {
      return(Building.GetBuildingincome());
    }

    public GameObject GetBuilding(Building.building)
    {
      return(Building.GettheBuilding());
    }
}
