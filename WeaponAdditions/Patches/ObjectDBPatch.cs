using HarmonyLib;
using WeaponAdditions.Functions;

namespace WeaponAdditions.Patches;

[HarmonyPatch]
public class ObjectDBPatch
{
    [HarmonyPriority(700)]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ObjectDB), nameof(ObjectDB.Awake))]
    public static void Awake_Postfix(ObjectDB __instance)
    {
        RegisterPrefabsToObjectDB.Init();
        RegisterRecipesToObjectDB.Init();
        __instance.UpdateItemHashes();
    }

    [HarmonyPriority(700)]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ObjectDB), nameof(ObjectDB.CopyOtherDB))]
    public static void CopyOtherDB_Postfix(ObjectDB __instance)
    {
        RegisterPrefabsToObjectDB.Init();
        RegisterRecipesToObjectDB.Init();
        __instance.UpdateItemHashes();
    }
}