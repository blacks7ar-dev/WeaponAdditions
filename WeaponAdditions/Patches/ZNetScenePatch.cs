using HarmonyLib;
using WeaponAdditions.Functions;

namespace WeaponAdditions.Patches;

[HarmonyPatch(typeof(ZNetScene), nameof(ZNetScene.Awake))]
public class ZNetScenePatch
{
    public static void Postfix(ZNetScene __instance)
    {
        RegisterPrefabsToZNetScene.Init();
        RegisterPrefabsToZNetScene.Effects();
    }
}