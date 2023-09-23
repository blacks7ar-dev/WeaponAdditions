using HarmonyLib;
using UnityEngine.SceneManagement;
using WeaponAdditions.Functions;

namespace WeaponAdditions.Patches;

[HarmonyPatch(typeof(ItemDrop), nameof(ItemDrop.Awake))]
public class ItemDropPatch
{
    public static void Postfix(ItemDrop __instance)
    {
        if (SceneManager.GetActiveScene().name != "main") return;
        if (__instance == null) return;
        switch (__instance.m_itemData.m_shared.m_name)
        {
            case "$bwa_blackmetalspear":
                StatsSetup.Spear(__instance);
                break;
            case "$bwa_broadsword":
                StatsSetup.Broadsword(__instance);
                break;
            case "$bwa_claymore":
                StatsSetup.Claymore(__instance);
                break;
            case "$bwa_giantaxe":
                StatsSetup.GiantAxe(__instance);
                break;
            case "$bwa_giantmace":
                StatsSetup.GiantMace(__instance);
                break;
            case "$bwa_greatsword":
                StatsSetup.Greatsword(__instance);
                break;
            case "$bwa_silveraxe":
                StatsSetup.SilverAxe(__instance);
                break;
            case "BWA_Tulwar":
                StatsSetup.Tulwar(__instance);
                break;
        }
    }
}