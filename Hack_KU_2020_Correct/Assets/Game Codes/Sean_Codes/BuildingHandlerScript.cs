﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using Sean.CharacterStats;

namespace Sean.BuildingPackage
{
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
        Apartment,
    }
    public class BuildingHandlerScript : MonoBehaviour
    {

        public GameObject PlacementObject;
        public GameObject StatsHandler;
        //public handleStats Stats;
        //public mousemanager MouseManager;
        private handleStats _stats;
        private mousemanager placementManager;
        private readonly List<Building> _buildingList;
        public readonly ReadOnlyCollection<Building> BuildingList;

        public BuildingHandlerScript()
        {
            _buildingList = new List<Building>();
            BuildingList = _buildingList.AsReadOnly();
        }
        void Start(){
            _stats = GameObject.Find("StatsHandler").GetComponentInChildren<handleStats>();
            placementManager = GameObject.Find("PlacementHandler").GetComponentInChildren<mousemanager>();
        }

        private void updateCurrentPlacementBuilding(Building _object)
        {
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

        public void addBuilding(Building _building)
        {
            _buildingList.Add(_building);
        }

        public void shopCheckout(BuildingType _type, GameObject _object)
        {
            Building _building;
            switch (_type)
            {
                case BuildingType.Road_Straight:
                    _building = new Building(_object, 2f, 0f, 0f, 1f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Road_Cross:
                    _building = new Building(_object, 2f, 0f, 0f, 1f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Road_Tee:
                    _building = new Building(_object, 2f, 0f, 0f, 1f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Road_Corner:
                    _building = new Building(_object, 2f, 0f, 0f, 1f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.House:
                    _building = new Building(_object, 200f, -25f, 5f, 50f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.House_Alt:
                    _building = new Building(_object, 300f, -35f, 10f, 100f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Skyscraper:
                    _building = new Building(_object, 800f, -200f, 500f, 350f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Coal_Power:
                    _building = new Building(_object, 300f, 100f, 100f, -50f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Power_Line:
                    _building = new Building(_object, 15f, 15f, 0f, -5f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Warehouse:
                    _building = new Building(_object, 500f, -150f, 150f, 200f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Watertower:
                    _building = new Building(_object, 150f, 0f, 20f, 25f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;
                case BuildingType.Apartment:
                    _building = new Building(_object, 600f, -100f, 400f, 300f, StatsHandler);
                    _buildingList.Add(_building);
                    updateCurrentPlacementBuilding(_building);
                    _stats.updateStatsFlat(_building.GetBuildingprice(), _building.GetBuildingpower(), _building.GetBuildingpopulation(), _building.GetBuildingincome(), _building.GettheBuilding());
                    break;

                default:
                    break;
            }

        }

    }

}