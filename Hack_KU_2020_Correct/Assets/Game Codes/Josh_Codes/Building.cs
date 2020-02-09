using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
  private float buildingprice = float.MinValue;
  private float buildingpower = float.MinValue;
  private float buildingpopulation = float.MinValue;
  private float buildingincome = float.MinValue;
  private GameObject theBuilding = null;

  public Building(){}

  public Building(GameObject Buldingpath, float Bprice, float Bpower , float Bpop, float Bincome)
  {
    theBuilding = Buldingpath;
    buildingprice = Bprice;
    buildingpower = Bpower;
    buildingpopulation = Bpop;
    buildingincome = Bincome;
  }

  public float GetBuildingprice()
  {
    return(buildingprice);
  }

  public float GetBuildingpower()
  {
    return(buildingpower);
  }

  public float GetBuildingpopulation()
  {
    return(buildingpopulation);
  }

  public float GetBuildingincome()
  {
    return(buildingincome);
  }

  public GameObject GettheBuilding()
  {
    return(theBuilding);
  }

}
