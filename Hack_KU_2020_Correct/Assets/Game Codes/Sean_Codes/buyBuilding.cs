﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sean.BuildingPackage;

public class buyBuilding : MonoBehaviour
{

    public GameObject RoadStraight;
    public GameObject RoadCross;
    public GameObject RoadCorner;
    public GameObject RoadTee;
    public GameObject CoalPower;
    public GameObject Warehouse;
    public GameObject Watertower;
    public GameObject House;
    public GameObject House2;
    public GameObject Skyscraper;
    public GameObject Apartment;

    public GameObject BuildingHandler;
    private BuildingHandlerScript _handler;

    void Start()
    {
        _handler = BuildingHandler.GetComponent<BuildingHandlerScript>();
    }

    public void buyRoadStraight()
    {
        _handler.shopCheckout(BuildingType.Road_Straight, RoadStraight);
    }
    public void buyRoadCross()
    {
        _handler.shopCheckout(BuildingType.Road_Cross, RoadCross);
    }
    public void buyRoadCorner()
    {
        _handler.shopCheckout(BuildingType.Road_Corner, RoadCorner);
    }
    public void buyRoadTee()
    {
        _handler.shopCheckout(BuildingType.Road_Tee, RoadTee);
    }
    public void buyCoalPower()
    {
        _handler.shopCheckout(BuildingType.Coal_Power, CoalPower);
    }
    public void buyWatertower()
    {
        _handler.shopCheckout(BuildingType.Watertower, Watertower);
    }
    public void buyWarehouse()
    {
        _handler.shopCheckout(BuildingType.Warehouse, Warehouse);
    }
    public void buyHouse()
    {
        _handler.shopCheckout(BuildingType.House, House);
    }
    public void buyHouse2()
    {
        _handler.shopCheckout(BuildingType.House_Alt, House2);
    }
    public void buySkyscraper()
    {
        _handler.shopCheckout(BuildingType.Skyscraper, Skyscraper);
    }
    public void buyApartment()
    {
        _handler.shopCheckout(BuildingType.Apartment, Apartment);
    }

}