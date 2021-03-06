﻿using UnityEngine;

namespace SurvivalExample
{
    [CreateAssetMenu]
    public class Configs : ScriptableObject
    {
        public GameObject GroundPrefab;
        public GameObject BuildingZoneCellPrefab;
        public GameObject FloorCanBuildedPrefab;
        public GameObject FloorBuildedPrefab;
        public GameObject PlayerHeroPrefab;
        public GameObject MainCameraContainerPrefab;
        public GameObject UiCameraContainerPrefab;
        public GameObject UiButtonPrefab;

        public Vector3 BuildingZoneSize;
        public float CellSize;
    }
}