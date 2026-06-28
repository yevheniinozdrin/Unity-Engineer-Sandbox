using UnityEngine;

namespace Sandbox.Cars
{
    public enum CarRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    [CreateAssetMenu(menuName = "Sandbox/Cars/Car Config", fileName = "CarConfig")]
    public class CarConfig : ScriptableObject
    {
        [Header("Identity")]
        public string id;
        public string displayName;
        public CarRarity rarity;

        [Header("Garage")]
        public Sprite icon;
        public GameObject prefab;

        [Header("Unlock")]
        public int price;
        public float unlockDistanceKm;
        public bool unlockedByDefault;

        [Header("Performance")]
        public float baseSpeed;
        public float baseTorque;
        public float baseHandling;
        public float baseBrakes;

        [Header("Upgrade Multipliers")]
        public float speedUpgradeMultiplier = 0.05f;
        public float torqueUpgradeMultiplier = 0.05f;
        public float handlingUpgradeMultiplier = 0.05f;
        public float brakesUpgradeMultiplier = 0.05f;
    }
}