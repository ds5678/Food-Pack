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
        public static void OnLoad() {
            ModAssetBundleManager.RegisterAssetBundle("food-pack.unity3d");

            GameObject energyDrinkPrefab = (GameObject)ModAssetBundleManager.LoadAsset("GEAR_AuroraEnergyDrink");
            ModUtils.RegisterConsoleGearName("AuroraEnergyDrink", energyDrinkPrefab.name);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableBackPack, energyDrinkPrefab, 5);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableKitchenCupboard, energyDrinkPrefab, 3);
            ModUtils.InsertIntoLootTable(LootTableName.LootTableFridge, energyDrinkPrefab, 5);
            ModUtils.InsertIntoLootTable(LootTableName.LootTablePlasticBox, energyDrinkPrefab, 2);
        }
    }
}
