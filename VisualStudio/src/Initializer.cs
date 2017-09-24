using AssetLoader;
using ModComponentMapper;
using UnityEngine;

using static ModComponentMapper.LootTableName;
using static ModComponentMapper.SceneName;

namespace FoodPack
{
    internal class Initializer
    {
        public static void OnLoad()
        {
            ModAssetBundleManager.RegisterAssetBundle("food-pack/food-pack.unity3d");
            ModSoundBankManager.RegisterSoundBank("food-pack/food-pack.bnk");

            InitBeerBottle();
            InitCatFood();
            InitCornflakes();
            InitEnergyDrink();
            InitWhiskyFlask();
        }

        private static void InitBeerBottle()
        {
            Mapper.Map("GEAR_BeerBottle")
                .RegisterInConsole("BeerBottle")
                .AddToLootTable(LootTableBackPack, 3)
                .AddToLootTable(LootTableKitchenCupboard, 5)
                .AddToLootTable(LootTableFridge, 10)
                .AddToLootTable(LootTableFreezer, 10)
                .AddToLootTable(LootTableWardrobe_regular, 2)
                .SpawnAt(CoastalHouseD, new Vector3(-4.839812f, 1.111778E-08f, -3.762105f), new Quaternion(0f, 0.1553226f, 0f, -0.9878638f), 0.5f)
                .SpawnAt(CoastalHouseD, new Vector3(-4.922742f, 8.160018E-09f, -3.724864f), new Quaternion(0f, 0.8732297f, 0f, 0.4873089f), 0.5f)
                .SpawnAt(CoastalHouseD, new Vector3(-4.866387f, 7.929452E-09f, -3.663046f), new Quaternion(0f, 0.991212f, 0f, -0.1322829f), 0.5f);
        }

        private static void InitCatFood()
        {
            Mapper.Map("GEAR_CatFood")
                .RegisterInConsole("CatFood")
                .AddToLootTable(LootTableKitchenCupboard, 5)
                .AddToLootTable(LootTableCabinet, 2)
                .AddToLootTable(LootTableHumanCorpse, 2)
                .AddToLootTable(LootTableLocker, 5)
                .AddToLootTable(LootTablePlasticBox, 3)
                .AddToLootTable(LootTableMetalBox, 3)
                .SpawnAt(QuonsetGasStation, new Vector3(7.514338f, 0.3989772f, 0.3159546f), new Quaternion(0f, 0.709298f, 0f, 0.7049087f), 0.8f)
                .SpawnAt(QuonsetGasStation, new Vector3(7.440349f, 0.3989772f, 0.2490942f), new Quaternion(0f, 0.191293f, 0f, 0.981533f), 0.8f)
                .SpawnAt(QuonsetGasStation, new Vector3(7.430581f, 0.3989772f, 0.3514916f), new Quaternion(0f, 0.8868808f, 0f, 0.4619984f), 0.8f);
        }

        private static void InitCornflakes()
        {
            Mapper.Map("GEAR_Cornflakes")
                .RegisterInConsole("Cornflakes")
                .AddToLootTable(LootTableKitchenCupboard, 10)
                .SpawnAt(FarmhouseA, new Vector3(3.525756f, 0.8793671f, 6.741885f), new Quaternion(0f, 0.7610618f, 0f, 0.6486793f), 0.8f)
                .SpawnAt(QuonsetGasStation, new Vector3(4.344324f, 0.3989773f, 0.3201076f), new Quaternion(0f, 0.7710883f, 0f, -0.6367282f), 0.6f);
        }

        private static void InitEnergyDrink()
        {
            Mapper.Map("GEAR_AuroraEnergyDrink")
                .RegisterInConsole("AuroraEnergyDrink")
                .AddToLootTable(LootTableBackPack, 5)
                .AddToLootTable(LootTableKitchenCupboard, 3)
                .AddToLootTable(LootTableFridge, 5)
                .AddToLootTable(LootTablePlasticBox, 2)
                .SpawnAt(QuonsetGasStation, new Vector3(6.441633f, 1.580515f, 0.5635147f), new Quaternion(0f, 0.3228113f, 0f, -0.9464633f), 0.8f)
                .SpawnAt(QuonsetGasStation, new Vector3(6.42512f, 1.580515f, 0.6616064f), new Quaternion(0f, 0.9846468f, 0f, 0.1745584f), 0.8f);
        }

        private static void InitWhiskyFlask()
        {
            Mapper.Map("GEAR_WhiskyFlask")
                .RegisterInConsole("WhiskyFlask")
                .AddToLootTable(LootTableBackPack, 1)
                .AddToLootTable(LootTableWardrobe_regular, 1)
                .AddToLootTable(LootTableFirstAidKit, 1)
                .AddToLootTable(LootTableBathroomCabinet, 1)
                .AddToLootTable(LootTableCashRegister, 1)
                .AddToLootTable(LootTableFishingDrawer, 3)
                .AddToLootTable(LootTableHumanCorpse, 3)
                .AddToLootTable(LootTableToolChestDrawer, 1)
                .SpawnAt(CoastalHouseE, new Vector3(0.136078f, 0.870868f, 0.02909133f), new Quaternion(0f, 0.0164255f, 0f, -0.9998651f), 0.5f)
                .SpawnAt(RadioControlHut, new Vector3(3.425682f, 0.531279f, 3.938539f), new Quaternion(0f, 0.1103397f, 0f, -0.9938939f), 1f);
        }
    }
}