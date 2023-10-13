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
            case "$bwa_battlehammer":
                StatsSetup.BattleHammer(__instance);
                break;
            case "$bwa_blackmetalspear":
                StatsSetup.BlackMetalSpear(__instance);
                break;
            case "$bwa_broadsword":
                StatsSetup.Broadsword(__instance);
                break;
            case "$bwa_bronzebattleaxe":
                StatsSetup.BronzeBattleAxe(__instance);
                break;
            case "$bwa_bronze_chainbuckler":
                StatsSetup.BronzeChainBuckler(__instance);
                break;
            case "$bwa_bronzehammer":
                StatsSetup.BronzeHammer(__instance);
                break;
            case "$bwa_bronzemace":
                StatsSetup.BronzeMace(__instance);
                break;
            case "$bwa_chainbuckler":
                StatsSetup.ChainBuckler(__instance);
                break;
            case "$bwa_claymore":
                StatsSetup.Claymore(__instance);
                break;
            case "$bwa_dagger":
                StatsSetup.Dagger(__instance);
                break;
            case "$bwa_darksword":
                StatsSetup.DarkSword(__instance);
                return;
            case "$bwa_draconic_dagger":
                StatsSetup.DraconicDagger(__instance);
                break;
            case "$bwa_draconic_greatsword":
                StatsSetup.DraconicGreatsword(__instance);
                break;
            case "$bwa_draconicscythe":
                StatsSetup.DraconicScythe(__instance);
                break;
            case "$bwa_draconicsword":
                StatsSetup.DraconicSword(__instance);
                break;
            case "$bwa_dragonblade":
                StatsSetup.DragonBlade(__instance);
                break;
            case "$bwa_dragonbone_greatsword":
                StatsSetup.DragonBoneGreatsword(__instance);
                break;
            case "$bwa_elvenaxe":
                StatsSetup.ElvenAxe(__instance);
                break;
            case "$bwa_elvenbow":
                StatsSetup.ElvenBow(__instance);
                break;
            case "$bwa_elvenhammer":
                StatsSetup.ElvenHammer(__instance);
                break;
            case "$bwa_elvenshield":
                StatsSetup.ElvenShield(__instance);
                break;
            case "$bwa_elvenspear":
                StatsSetup.ElvenSpear(__instance);
                break;
            case "$bwa_elvensword":
                StatsSetup.ElvenSword(__instance);
                break;
            case "$bwa_flametal_greatsword":
                StatsSetup.FlametalGreatsword(__instance);
                break;
            case "$bwa_flametal_hammer":
                StatsSetup.FlametalHammer(__instance);
                break;
            case "$bwa_flametal_sword":
                StatsSetup.FlametalSword(__instance);
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
            case "$bwa_ironspiked_mace":
                StatsSetup.IronSpikedMace(__instance);
                break;
            case "$bwa_obsidianbuckler":
                StatsSetup.ObsidianBuckler(__instance);
                break;
            case "$bwa_obsidian_greatsword":
                StatsSetup.ObsidianGreatsword(__instance);
                break;
            case "$bwa_poisonousspiked_mace":
                StatsSetup.PoisonousSpikedMace(__instance);
                break;
            case "$bwa_seekerbow":
                StatsSetup.SeekerBow(__instance);
                break;
            case "$bwa_silveraxe":
                StatsSetup.SilverAxe(__instance);
                break;
            case "$bwa_tulwar":
                StatsSetup.Tulwar(__instance);
                break;
        }
    }
}