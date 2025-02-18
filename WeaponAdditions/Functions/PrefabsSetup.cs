﻿using ItemManager;
using UnityEngine;

namespace WeaponAdditions.Functions;

public static class PrefabsSetup
{
    private static AssetBundle _weaponBundle;

    public static void Init()
    {
        _weaponBundle = PrefabManager.RegisterAssetBundle("weaponbundle");
        var burning = ScriptableObject.CreateInstance<SE_Burning>();
        var frost = ScriptableObject.CreateInstance<SE_Frost>();
        var poison = ScriptableObject.CreateInstance<SE_Poison>();
        Item item = new(_weaponBundle, "BWA_BattleHammer");
        item.Crafting.Add(CraftingTable.Forge, 1);
        item.RequiredItems.Add("Iron", 32);
        item.RequiredItems.Add("Bronze", 12);
        item.RequiredItems.Add("ElderBark", 8);
        item.RequiredUpgradeItems.Add("Iron",16);
        item.RequiredUpgradeItems.Add("Bronze", 6);
        item.RequiredUpgradeItems.Add("ElderBark", 4);
        item.Configurable = Configurability.Full;
        Item item2 = new(_weaponBundle, "BWA_BlackMetalSpear");
        item2.Crafting.Add(CraftingTable.Forge, 1);
        item2.RequiredItems.Add("BlackMetal", 30);
        item2.RequiredItems.Add("FineWood", 10);
        item2.RequiredItems.Add("LinenThread", 5);
        item2.RequiredItems.Add("Iron", 10);
        item2.RequiredUpgradeItems.Add("BlackMetal", 15);
        item2.RequiredUpgradeItems.Add("LinenThread", 5);
        item2.RequiredUpgradeItems.Add("Iron", 5);
        item2.Configurable = Configurability.Full;
        Item item3 = new(_weaponBundle, "BWA_Broadsword");
        item3.Crafting.Add(CraftingTable.Forge, 1);
        item3.RequiredItems.Add("BlackMetal", 10);
        item3.RequiredItems.Add("Silver", 60);
        item3.RequiredItems.Add("Iron", 30);
        item3.RequiredItems.Add("YggdrasilWood", 10);
        item3.RequiredUpgradeItems.Add("Silver", 30);
        item3.RequiredUpgradeItems.Add("Iron", 15);
        item3.RequiredUpgradeItems.Add("YggdrasilWood", 5);
        item3.Configurable = Configurability.Full;
        Item item4 = new(_weaponBundle, "BWA_BronzeBattleAxe");
        item4.Crafting.Add(CraftingTable.Forge, 1);
        item4.RequiredItems.Add("Bronze", 22);
        item4.RequiredItems.Add("Copper", 6);
        item4.RequiredItems.Add("RoundLog", 4);
        item4.RequiredUpgradeItems.Add("Bronze", 11);
        item4.RequiredUpgradeItems.Add("Copper", 3);
        item4.Configurable = Configurability.Full;
        Item item5 = new(_weaponBundle, "BWA_BronzeChainBuckler");
        item5.Crafting.Add(CraftingTable.Forge, 1);
        item5.RequiredItems.Add("Chain", 1);
        item5.RequiredItems.Add("Bronze", 26);
        item5.RequiredItems.Add("FineWood", 16);
        item5.RequiredItems.Add("Tin", 10);
        item5.RequiredUpgradeItems.Add("Bronze", 13);
        item5.RequiredUpgradeItems.Add("FineWood", 8);
        item5.RequiredUpgradeItems.Add("Tin", 5);
        item5.Configurable = Configurability.Full;
        Item item6 = new(_weaponBundle, "BWA_BronzeHammer");
        item6.Crafting.Add(CraftingTable.Forge, 1);
        item6.RequiredItems.Add("Bronze", 22);
        item6.RequiredItems.Add("Copper", 6);
        item6.RequiredItems.Add("RoundLog", 4);
        item6.RequiredUpgradeItems.Add("Bronze", 11);
        item6.RequiredUpgradeItems.Add("Copper", 3);
        item6.Configurable = Configurability.Full;
        Item item7 = new(_weaponBundle, "BWA_BronzeMace");
        item7.Crafting.Add(CraftingTable.Forge, 1);
        item7.RequiredItems.Add("Bronze", 22);
        item7.RequiredItems.Add("Copper", 6);
        item7.RequiredItems.Add("RoundLog", 4);
        item7.RequiredUpgradeItems.Add("Bronze", 11);
        item7.RequiredUpgradeItems.Add("Copper", 3);
        item7.Configurable = Configurability.Full;
        Item item8 = new(_weaponBundle, "BWA_ChainBuckler");
        item8.Crafting.Add(CraftingTable.Forge, 1);
        item8.RequiredItems.Add("Chain", 1);
        item8.RequiredItems.Add("Iron", 32);
        item8.RequiredItems.Add("ElderBark", 22);
        item8.RequiredUpgradeItems.Add("Iron", 16);
        item8.RequiredUpgradeItems.Add("ElderBark", 11);
        item8.Configurable = Configurability.Full;
        Item item9 = new(_weaponBundle, "BWA_Claymore");
        item9.Crafting.Add(CraftingTable.Forge, 1);
        item9.RequiredItems.Add("Silver", 40);
        item9.RequiredItems.Add("Iron", 20);
        item9.RequiredItems.Add("FineWood", 15);
        item9.RequiredItems.Add("Bronze", 10);
        item9.RequiredUpgradeItems.Add("Silver", 20);
        item9.RequiredUpgradeItems.Add("Iron", 10);
        item9.RequiredUpgradeItems.Add("FineWood", 7);
        item9.Configurable = Configurability.Full;
        Item item10 = new(_weaponBundle, "BWA_Dagger");
        item10.Crafting.Add(CraftingTable.Forge, 1);
        item10.RequiredItems.Add("Iron", 18);
        item10.RequiredItems.Add("LeatherScraps", 12);
        item10.RequiredItems.Add("ElderBark", 6);
        item10.RequiredUpgradeItems.Add("Iron", 9);
        item10.RequiredUpgradeItems.Add("LeatherScraps", 6);
        item10.Configurable = Configurability.Full;
        Item item11 = new(_weaponBundle, "BWA_DarkSword");
        item11.Crafting.Add(CraftingTable.Forge, 1);
        item11.RequiredItems.Add("TrophySurtling", 1);
        item11.RequiredItems.Add("Iron", 42);
        item11.RequiredItems.Add("Bronze", 6);
        item11.RequiredItems.Add("ElderBark", 4);
        item11.RequiredUpgradeItems.Add("Iron", 21);
        item11.RequiredUpgradeItems.Add("Bronze", 3);
        item11.RequiredUpgradeItems.Add("ElderBark", 2);
        item11.Configurable = Configurability.Full;
        item11.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item12 = new(_weaponBundle, "BWA_DraconicDagger");
        item12.Crafting.Add(CraftingTable.Forge, 1);
        item12.RequiredItems.Add("FreezeGland", 26);
        item12.RequiredItems.Add("Crystal", 18);
        item12.RequiredItems.Add("Silver", 32);
        item12.RequiredItems.Add("Iron", 14);
        item12.RequiredUpgradeItems.Add("FreezeGland", 13);
        item12.RequiredUpgradeItems.Add("Crystal", 9);
        item12.RequiredUpgradeItems.Add("Silver", 16);
        item12.Configurable = Configurability.Full;
        item12.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = frost;
        Item item13 = new(_weaponBundle, "BWA_DraconicGreatSword");
        item13.Crafting.Add(CraftingTable.Forge, 1);
        item13.RequiredItems.Add("FreezeGland", 38);
        item13.RequiredItems.Add("Crystal", 24);
        item13.RequiredItems.Add("Silver", 40);
        item13.RequiredItems.Add("Obsidian", 32);
        item13.RequiredUpgradeItems.Add("FreezeGland", 19);
        item13.RequiredUpgradeItems.Add("Silver", 20);
        item13.RequiredUpgradeItems.Add("Obsidian", 16);
        item13.Configurable = Configurability.Full;
        item13.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = frost;
        Item item14 = new(_weaponBundle, "BWA_DraconicScythe");
        item14.Crafting.Add(CraftingTable.Forge, 1);
        item14.RequiredItems.Add("FreezeGland", 24);
        item14.RequiredItems.Add("Crystal", 36);
        item14.RequiredItems.Add("Silver", 38);
        item14.RequiredItems.Add("ElderBark", 10);
        item14.RequiredUpgradeItems.Add("Crystal", 18);
        item14.RequiredUpgradeItems.Add("Silver", 19);
        item14.Configurable = Configurability.Full;
        item14.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = frost;
        Item item15 = new(_weaponBundle, "BWA_DraconicSword");
        item15.Crafting.Add(CraftingTable.Forge, 1);
        item15.RequiredItems.Add("FreezeGland", 34);
        item15.RequiredItems.Add("Crystal", 20);
        item15.RequiredItems.Add("Silver", 42);
        item15.RequiredItems.Add("Obsidian", 40);
        item15.RequiredUpgradeItems.Add("Silver", 21);
        item15.RequiredUpgradeItems.Add("Obsidian", 20);
        item15.Configurable = Configurability.Full;
        item15.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = frost;
        Item item16 = new(_weaponBundle, "BWA_DragonBlade");
        item16.Crafting.Add(CraftingTable.Forge, 1);
        item16.RequiredItems.Add("FreezeGland", 8);
        item16.RequiredItems.Add("Silver", 38);
        item16.RequiredItems.Add("Iron", 12);
        item16.RequiredItems.Add("Tin", 8);
        item16.RequiredUpgradeItems.Add("Silver", 18);
        item16.RequiredUpgradeItems.Add("Iron", 6);
        item16.RequiredUpgradeItems.Add("Tin", 4);
        item16.Configurable = Configurability.Full;
        Item item17 = new(_weaponBundle, "BWA_ElvenAxe");
        item17.Crafting.Add(CraftingTable.BlackForge, 1);
        item17.RequiredItems.Add("Thunderstone", 10);
        item17.RequiredItems.Add("Eitr", 52);
        item17.RequiredItems.Add("Iron", 44);
        item17.RequiredItems.Add("Mandible", 22);
        item17.RequiredUpgradeItems.Add("Eitr", 26);
        item17.RequiredUpgradeItems.Add("Iron", 22);
        item17.RequiredUpgradeItems.Add("Mandible", 11);
        item17.Configurable = Configurability.Full;
        if (!Plugin._IsBowPluginInstalled)
        {
            Item item18 = new(_weaponBundle, "BWA_ElvenBow");
            item18.Crafting.Add(CraftingTable.BlackForge, 1);
            item18.RequiredItems.Add("Thunderstone", 10);
            item18.RequiredItems.Add("Eitr", 52);
            item18.RequiredItems.Add("Iron", 44);
            item18.RequiredItems.Add("LinenThread", 28);
            item18.RequiredUpgradeItems.Add("Eitr", 26);
            item18.RequiredUpgradeItems.Add("Iron", 22);
            item18.RequiredUpgradeItems.Add("LinenThread", 14);
            item18.Configurable = Configurability.Full;   
        }
        else
        {
            _ = new Item(_weaponBundle, "BWA_ElvenBow");
        }

        Item item19 = new(_weaponBundle, "BWA_ElvenHammer");
        item19.Crafting.Add(CraftingTable.BlackForge, 1);
        item19.RequiredItems.Add("Thunderstone", 10);
        item19.RequiredItems.Add("Eitr", 52);
        item19.RequiredItems.Add("Iron", 44);
        item19.RequiredItems.Add("Mandible", 22);
        item19.RequiredUpgradeItems.Add("Eitr", 26);
        item19.RequiredUpgradeItems.Add("Iron", 22);
        item19.RequiredUpgradeItems.Add("Mandible", 11);
        item19.Configurable = Configurability.Full;
        Item item20 = new(_weaponBundle, "BWA_ElvenShield");
        item20.Crafting.Add(CraftingTable.BlackForge, 1);
        item20.RequiredItems.Add("Thunderstone", 10);
        item20.RequiredItems.Add("Eitr", 52);
        item20.RequiredItems.Add("Iron", 44);
        item20.RequiredItems.Add("Carapace", 28);
        item20.RequiredUpgradeItems.Add("Eitr", 26);
        item20.RequiredUpgradeItems.Add("Iron", 22);
        item20.RequiredUpgradeItems.Add("Carapace", 14);
        item20.Configurable = Configurability.Full;
        Item item21 = new(_weaponBundle, "BWA_ElvenSpear");
        item21.Crafting.Add(CraftingTable.BlackForge, 1);
        item21.RequiredItems.Add("Thunderstone", 10);
        item21.RequiredItems.Add("Eitr", 52);
        item21.RequiredItems.Add("Iron", 44);
        item21.RequiredItems.Add("Mandible", 22);
        item21.RequiredUpgradeItems.Add("Eitr", 26);
        item21.RequiredUpgradeItems.Add("Iron", 22);
        item21.RequiredUpgradeItems.Add("Mandible", 11);
        item21.Configurable = Configurability.Full;
        Item item22 = new(_weaponBundle, "BWA_ElvenSword");
        item22.Crafting.Add(CraftingTable.BlackForge, 1);
        item22.RequiredItems.Add("Thunderstone", 10);
        item22.RequiredItems.Add("Eitr", 52);
        item22.RequiredItems.Add("Iron", 44);
        item22.RequiredItems.Add("Mandible", 22);
        item22.RequiredUpgradeItems.Add("Eitr", 26);
        item22.RequiredUpgradeItems.Add("Iron", 22);
        item22.RequiredUpgradeItems.Add("Mandible", 11);
        item22.Configurable = Configurability.Full;
        Item item23 = new(_weaponBundle, "BWA_FlametalGreatSword");
        item23.Crafting.Add(CraftingTable.BlackForge, 1);
        item23.RequiredItems.Add("TrophySurtling", 2);
        item23.RequiredItems.Add("FlametalNew", 36);
        item23.RequiredItems.Add("BlackMetal", 32);
        item23.RequiredItems.Add("Eitr", 46);
        item23.RequiredUpgradeItems.Add("FlametalNew", 18);
        item23.RequiredUpgradeItems.Add("BlackMetal", 16);
        item23.RequiredUpgradeItems.Add("Eitr", 23);
        item23.Configurable = Configurability.Full;
        item23.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item24 = new(_weaponBundle, "BWA_FlametalHammer");
        item24.Crafting.Add(CraftingTable.BlackForge, 1);
        item24.RequiredItems.Add("TrophySurtling", 2);
        item24.RequiredItems.Add("FlametalNew", 36);
        item24.RequiredItems.Add("BlackMetal", 32);
        item24.RequiredItems.Add("Eitr", 46);
        item24.RequiredUpgradeItems.Add("FlametalNew", 18);
        item24.RequiredUpgradeItems.Add("BlackMetal", 16);
        item24.RequiredUpgradeItems.Add("Eitr", 23);
        item24.Configurable = Configurability.Full;
        item24.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item25 = new(_weaponBundle, "BWA_FlametalSword");
        item25.Crafting.Add(CraftingTable.BlackForge, 1);
        item25.RequiredItems.Add("TrophySurtling", 2);
        item25.RequiredItems.Add("FlametalNew", 36);
        item25.RequiredItems.Add("BlackMetal", 32);
        item25.RequiredItems.Add("Eitr", 46);
        item25.RequiredUpgradeItems.Add("FlametalNew", 18);
        item25.RequiredUpgradeItems.Add("BlackMetal", 16);
        item25.RequiredUpgradeItems.Add("Eitr", 23);
        item25.Configurable = Configurability.Full;
        item25.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item26 = new(_weaponBundle, "BWA_GiantAxe");
        item26.Crafting.Add(CraftingTable.Forge, 1);
        item26.RequiredItems.Add("BlackMetal", 60);
        item26.RequiredItems.Add("FineWood", 20);
        item26.RequiredItems.Add("LinenThread", 5);
        item26.RequiredItems.Add("Iron", 20);
        item26.RequiredUpgradeItems.Add("BlackMetal", 30);
        item26.RequiredUpgradeItems.Add("LinenThread", 5);
        item26.RequiredUpgradeItems.Add("Iron", 10);
        item26.Configurable = Configurability.Full;
        Item item27 = new(_weaponBundle, "BWA_GiantMace");
        item27.Crafting.Add(CraftingTable.Forge, 1);
        item27.RequiredItems.Add("Bronze", 30);
        item27.RequiredItems.Add("RoundLog", 10);
        item27.RequiredItems.Add("Copper", 5);
        item27.RequiredItems.Add("Tin", 5);
        item27.RequiredUpgradeItems.Add("Bronze", 15);
        item27.RequiredUpgradeItems.Add("Copper", 3);
        item27.RequiredUpgradeItems.Add("Tin", 2);
        item27.Configurable = Configurability.Full;
        Item item28 = new(_weaponBundle, "BWA_Greatsword");
        item28.Crafting.Add(CraftingTable.Forge, 1);
        item28.RequiredItems.Add("Iron", 50);
        item28.RequiredItems.Add("ElderBark", 10);
        item28.RequiredItems.Add("Tin", 15);
        item28.RequiredItems.Add("Chitin", 10);
        item28.RequiredUpgradeItems.Add("Iron", 25);
        item28.RequiredUpgradeItems.Add("Tin", 8);
        item28.RequiredUpgradeItems.Add("Chitin", 5);
        item28.Configurable = Configurability.Full;
        Item item29 = new(_weaponBundle, "BWA_DragonBoneGreatsword");
        item29.Crafting.Add(CraftingTable.Forge, 1);
        item29.RequiredItems.Add("TrophyDragonQueen", 1);
        item29.RequiredItems.Add("Silver", 32);
        item29.RequiredItems.Add("Iron", 24);
        item29.RequiredItems.Add("WolfFang", 8);
        item29.RequiredUpgradeItems.Add("Silver", 16);
        item29.RequiredUpgradeItems.Add("Iron", 12);
        item29.RequiredUpgradeItems.Add("WolfFang", 4);
        item29.Configurable = Configurability.Full;
        Item item30 = new(_weaponBundle, "BWA_IronSpikedMace");
        item30.Crafting.Add(CraftingTable.Forge, 1);
        item30.RequiredItems.Add("Iron", 30);
        item30.RequiredItems.Add("ElderBark", 8);
        item30.RequiredItems.Add("RoundLog", 4);
        item30.RequiredUpgradeItems.Add("Iron", 15);
        item30.RequiredUpgradeItems.Add("ElderBark", 4);
        item30.Configurable = Configurability.Full;
        Item item31 = new(_weaponBundle, "BWA_ObsidianBuckler");
        item31.Crafting.Add(CraftingTable.Forge, 1);
        item31.RequiredItems.Add("Silver", 18);
        item31.RequiredItems.Add("Iron", 12);
        item31.RequiredItems.Add("Obsidian", 56);
        item31.RequiredUpgradeItems.Add("Silver", 9);
        item31.RequiredUpgradeItems.Add("Iron", 6);
        item31.RequiredUpgradeItems.Add("Obsidian", 28);
        item31.Configurable = Configurability.Full;
        Item item32 = new(_weaponBundle, "BWA_ObsidianGreatsword");
        item32.Crafting.Add(CraftingTable.Forge, 1);
        item32.RequiredItems.Add("Silver", 10);
        item32.RequiredItems.Add("Iron", 32);
        item32.RequiredItems.Add("Obsidian", 86);
        item32.RequiredUpgradeItems.Add("Silver", 5);
        item32.RequiredUpgradeItems.Add("Iron", 16);
        item32.RequiredUpgradeItems.Add("Obsidian", 43);
        item32.Configurable = Configurability.Full;
        Item item33 = new(_weaponBundle, "BWA_PoisonousSpikedMace");
        item33.Crafting.Add(CraftingTable.Forge, 1);
        item33.RequiredItems.Add("Iron", 30);
        item33.RequiredItems.Add("Guck", 34);
        item33.RequiredItems.Add("ElderBark", 12);
        item33.RequiredItems.Add("LeatherScraps", 12);
        item33.RequiredUpgradeItems.Add("Iron", 15);
        item33.RequiredUpgradeItems.Add("Guck", 17);
        item33.RequiredUpgradeItems.Add("ElderBark", 6);
        item33.Configurable = Configurability.Full;
        item33.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = poison;
        if (!Plugin._IsBowPluginInstalled)
        {
            Item item34 = new(_weaponBundle, "BWA_SeekerBow");
            item34.Crafting.Add(CraftingTable.BlackForge, 1);
            item34.RequiredItems.Add("TrophySeeker", 2);
            item34.RequiredItems.Add("BlackMetal", 28);
            item34.RequiredItems.Add("Mandible", 22);
            item34.RequiredItems.Add("Eitr", 22);
            item34.RequiredUpgradeItems.Add("BlackMetal", 14);
            item34.RequiredUpgradeItems.Add("Mandible", 11);
            item34.RequiredUpgradeItems.Add("Eitr", 11);
            item34.Configurable = Configurability.Full;
            item34.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        }
        else
        {
            Item item34 = new(_weaponBundle, "BWA_SeekerBow");
            item34.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        }
        Item item35 = new(_weaponBundle, "BWA_SilverAxe");
        item35.Crafting.Add(CraftingTable.Forge, 1);
        item35.RequiredItems.Add("Silver", 60);
        item35.RequiredItems.Add("WolfClaw", 10);
        item35.RequiredItems.Add("FineWood", 15);
        item35.RequiredItems.Add("Iron", 10);
        item35.RequiredUpgradeItems.Add("Silver", 30);
        item35.RequiredUpgradeItems.Add("WolfClaw", 5);
        item35.RequiredUpgradeItems.Add("Iron", 5);
        item35.Configurable = Configurability.Full;
        Item item36 = new(_weaponBundle, "BWA_Tulwar");
        item36.Crafting.Add(CraftingTable.Forge, 1);
        item36.RequiredItems.Add("BlackMetal", 70);
        item36.RequiredItems.Add("FineWood", 20);
        item36.RequiredItems.Add("LinenThread", 10);
        item36.RequiredItems.Add("Iron", 30);
        item36.RequiredUpgradeItems.Add("BlackMetal", 35);
        item36.RequiredUpgradeItems.Add("LinenThread", 5);
        item36.RequiredUpgradeItems.Add("Iron", 15);
        item36.Configurable = Configurability.Full;
        Item item37 = new(_weaponBundle, "BWA_FlametalAxe");
        item37.Crafting.Add(CraftingTable.Forge, 1);
        item37.RequiredItems.Add("TrophySurtling", 2);
        item37.RequiredItems.Add("FlametalNew", 36);
        item37.RequiredItems.Add("BlackMetal", 32);
        item37.RequiredItems.Add("Eitr", 46);
        item37.RequiredUpgradeItems.Add("FlametalNew", 18);
        item37.RequiredUpgradeItems.Add("BlackMetal", 16);
        item37.RequiredUpgradeItems.Add("Eitr", 23);
        item37.Configurable = Configurability.Full;
        item37.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item38 = new(_weaponBundle, "BWA_FlametalDagger");
        item38.Crafting.Add(CraftingTable.Forge, 1);
        item38.RequiredItems.Add("TrophySurtling", 1);
        item38.RequiredItems.Add("FlametalNew", 28);
        item38.RequiredItems.Add("BlackMetal", 26);
        item38.RequiredItems.Add("Eitr", 38);
        item38.RequiredUpgradeItems.Add("FlametalNew", 14);
        item38.RequiredUpgradeItems.Add("BlackMetal", 13);
        item38.RequiredUpgradeItems.Add("Eitr", 18);
        item38.Configurable = Configurability.Full;
        item38.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item39 = new(_weaponBundle, "BWA_FlametalPolearm");
        item39.Crafting.Add(CraftingTable.Forge, 1);
        item39.RequiredItems.Add("TrophySurtling", 2);
        item39.RequiredItems.Add("FlametalNew", 36);
        item39.RequiredItems.Add("BlackMetal", 32);
        item39.RequiredItems.Add("Eitr", 46);
        item39.RequiredUpgradeItems.Add("FlametalNew", 18);
        item39.RequiredUpgradeItems.Add("BlackMetal", 16);
        item39.RequiredUpgradeItems.Add("Eitr", 23);
        item39.Configurable = Configurability.Full;
        item39.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
        Item item40 = new(_weaponBundle, "BWA_FlametalScythe");
        item40.Crafting.Add(CraftingTable.Forge, 1);
        item40.RequiredItems.Add("TrophySurtling", 2);
        item40.RequiredItems.Add("FlametalNew", 36);
        item40.RequiredItems.Add("BlackMetal", 32);
        item40.RequiredItems.Add("Eitr", 46);
        item40.RequiredUpgradeItems.Add("FlametalNew", 18);
        item40.RequiredUpgradeItems.Add("BlackMetal", 16);
        item40.RequiredUpgradeItems.Add("Eitr", 23);
        item40.Configurable = Configurability.Full;
        item40.Prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_attackStatusEffect = burning;
    }

    public static void Effects()
    {
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_dagger_projectile");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_block_camshake");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_himminafl_aoe");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_himminafl_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_hit_camshake");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_hit_camshake_knife");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_sledge_demolisher_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_sledge_demolisher_hit1");
        var go = PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_StaffShield_Hit");
        ShaderReplacer.Replace(go);
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_fx_swing_camshake");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_arrow_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_atgeir_attack");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_axe_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_axe_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_battleaxe_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_battleaxe_swing_wosh");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_bow_draw");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_bow_fire");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_club_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_club_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_knife_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_kromsword_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_metal_blocked");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_sledge_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_spear_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_spear_throw");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_sword_hit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_sword_swing");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_sfx_wood_blocked");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_arrowhit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_blocked");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_bow_fire");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_clubhit");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_HitSparks");
        PrefabManager.RegisterPrefab(_weaponBundle, "bwa_vfx_sledge_hit");
    }
}