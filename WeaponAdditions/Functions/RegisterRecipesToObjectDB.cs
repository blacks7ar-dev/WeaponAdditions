using UnityEngine;
using WeaponAdditions.Utils;

namespace WeaponAdditions.Functions;

public static class RegisterRecipesToObjectDB
{
    private static ZNetScene _zNetScene => ZNetScene.instance;
    private static ObjectDB _objectDB => ObjectDB.instance;

    public static void Init()
    {
        if (!Helper.ObjectDBAwake()) return;
        if (!Helper.ZNetSceneAwake()) return;
        Spear();
        Broadsword();
        Claymore();
        GiantAxe();
        GiantMace();
        Greatsword();
        SilverAxe();
        Tulwar();
    }

    private static void Spear()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_BlackMetalSpear";
        recipe.m_item = PrefabsSetup._blackMetalSpear.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._spearEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._spearMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._spearMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._spearMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._spearMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void Broadsword()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_Broadsword";
        recipe.m_item = PrefabsSetup._broadsword.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._broadswordEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._broadswordMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._broadswordMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._broadswordMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._broadswordMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void Claymore()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_Claymore";
        recipe.m_item = PrefabsSetup._claymore.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._claymoreEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._claymoreMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._claymoreMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._claymoreMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._claymoreMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void GiantAxe()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_GiantAxe";
        recipe.m_item = PrefabsSetup._giantAxe.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._giantAxeEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._giantAxeMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._giantAxeMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._giantAxeMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._giantAxeMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void GiantMace()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_GiantMace";
        recipe.m_item = PrefabsSetup._giantMace.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._giantMaceEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._giantMaceMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._giantMaceMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._giantMaceMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._giantMaceMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void Greatsword()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_Greatsword";
        recipe.m_item = PrefabsSetup._greatsword.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._greatswordEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._greatswordMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._greatswordMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._greatswordMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._greatswordMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void SilverAxe()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_SilverAxe";
        recipe.m_item = PrefabsSetup._silverAxe.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._silverAxeEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._silverAxeMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._silverAxeMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._silverAxeMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._silverAxeMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }

    private static void Tulwar()
    {
        var recipe = ScriptableObject.CreateInstance<Recipe>();
        recipe.name = "Recipe_BWA_Tulwar";
        recipe.m_item = PrefabsSetup._tulwar.GetComponent<ItemDrop>();
        recipe.m_amount = 1;
        recipe.m_enabled = ConfigSetup._tulwarEnable.Value;
        recipe.m_qualityResultAmountMultiplier = 1;
        recipe.m_craftingStation = _zNetScene.GetPrefab("forge").GetComponent<CraftingStation>();
        recipe.m_repairStation = recipe.m_craftingStation;
        recipe.m_minStationLevel = 1;
        recipe.m_requireOnlyOneIngredient = false;
        var subs1 = ConfigSetup._tulwarMat1.Value.Split(':', ' ');
        var subs2 = ConfigSetup._tulwarMat2.Value.Split(':', ' ');
        var subs3 = ConfigSetup._tulwarMat3.Value.Split(':', ' ');
        var subs4 = ConfigSetup._tulwarMat4.Value.Split(':', ' ');
        recipe.m_resources = new Piece.Requirement[]
        {
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs1[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs1[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs1[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs2[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs2[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs2[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs3[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs3[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs3[2]),
                m_recover = true
            },
            new()
            {
                m_resItem = _objectDB.GetItemPrefab(subs4[0]).GetComponent<ItemDrop>(),
                m_amount = int.Parse(subs4[1]),
                m_extraAmountOnlyOneIngredient = 0,
                m_amountPerLevel = int.Parse(subs4[2]),
                m_recover = true
            }
        };
        _objectDB.AddRecipe(recipe);
    }
}