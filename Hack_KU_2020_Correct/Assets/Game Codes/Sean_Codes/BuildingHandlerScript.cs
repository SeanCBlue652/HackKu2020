using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHandlerScript : MonoBehaviour
{
    public BuildingHandlerScript(){}

    public float GetPrices(Building prices)
    {
      return(Building.GetBuildingprice());
    }

    public float Getpower(Building power)
    {
      return(Building.GetBuildingpower());
    }

    public float Getpop(Building Population)
    {
      return(Building.GetBuildingpopulation());
    }

    public float Getincome(Building income)
    {
      return(Building.GetBuildingincome());
    }

    public GameObject GetBuilding(Building BHSbuilding)
    {
      return(Building.GettheBuilding());
    }
}
