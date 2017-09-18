using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AssetLoader;
using ModComponentMapper;
using UnityEngine;

namespace FoodPack
{
    class Initializer
    {
        public static void OnLoad()
        {
            ModAssetBundleManager.RegisterAssetBundle("food-pack/food-pack.unity3d");
            ModSoundBankManager.RegisterSoundBank("food-pack/food-pack.bnk");

            initEnergyDrink();
            initCornflakes();
            initBeerBottle();
        }

        private static void initEnergyDrink()
        {
            GameObject energyDrinkPrefab = (GameObject)ModAssetBundleManager.LoadAsset("GEAR_AuroraEnergyDrink");
            ModUtils.RegisterConsoleGearName("AuroraEnergyDrink", energyDrinkPrefab.name);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableBackPack, energyDrinkPrefab, 5);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableKitchenCupboard, energyDrinkPrefab, 3);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableFridge, energyDrinkPrefab, 5);
            ModUtils.InsertIntoLootTable(LootTableName.LootTablePlasticBox, energyDrinkPrefab, 2);
        }

        private static void initCornflakes()
        {
            GameObject cornFlakesPrefab = (GameObject)ModAssetBundleManager.LoadAsset("GEAR_Cornflakes");
            ModUtils.RegisterConsoleGearName("Cornflakes", cornFlakesPrefab.name);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableKitchenCupboard, cornFlakesPrefab, 10);

            GearSpawnInfo spawnInfo = new GearSpawnInfo();
            spawnInfo.PrefabName = cornFlakesPrefab.name;
            spawnInfo.Position = new Vector3(3.525756f, 0.8793671f, 6.741885f);
            spawnInfo.Rotation = new Quaternion(0f, 0.7610618f, 0f, 0.6486793f);
            spawnInfo.SpawnChance = 0.8f;
            GearSpawner.AddGearSpawnInfo("FarmHouseA", spawnInfo);
        }

        private static void initBeerBottle()
        {
            GameObject beerBottlePrefab = (GameObject)ModAssetBundleManager.LoadAsset("GEAR_BeerBottle");
            ModUtils.RegisterConsoleGearName("BeerBottle", beerBottlePrefab.name);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableBackPack, beerBottlePrefab, 3);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableKitchenCupboard, beerBottlePrefab, 5);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableFridge, beerBottlePrefab, 10);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableFreezer, beerBottlePrefab, 10);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableWardrobe_regular, beerBottlePrefab, 2);
        }
    }
}
