using BepInEx.Configuration;
using WeaponAdditions.Utils;

namespace WeaponAdditions.Functions;

public static class ConfigSetup
{
    public static ConfigEntry<float> _battleHammerBluntDmg;
    public static ConfigEntry<float> _battleHammerAttackForce;
    public static ConfigEntry<float> _blackMetalSpearPierceDmg;
    public static ConfigEntry<float> _blackMetalSpearAttackForce;
    public static ConfigEntry<float> _broadswordSlashDmg;
    public static ConfigEntry<float> _broadswordSpiritDmg;
    public static ConfigEntry<float> _broadswordAttackForce;
    public static ConfigEntry<float> _bronzeBattleAxeSlashDmg;
    public static ConfigEntry<float> _bronzeBattleAxeChopDmg;
    public static ConfigEntry<float> _bronzeBattleAxeAttackForce;
    public static ConfigEntry<float> _bronzeChainBucklerBlockPower;
    public static ConfigEntry<float> _bronzeChainBucklerDeflectionForce;
    public static ConfigEntry<float> _bronzeChainBucklerTimedBlockBonus;
    public static ConfigEntry<float> _bronzeHammerBluntDmg;
    public static ConfigEntry<float> _bronzeHammerAttackForce;
    public static ConfigEntry<float> _bronzeMaceBluntDmg;
    public static ConfigEntry<float> _bronzeMaceAttackForce;
    public static ConfigEntry<float> _chainBucklerBlockPower;
    public static ConfigEntry<float> _chainBucklerDeflectionForce;
    public static ConfigEntry<float> _chainBucklerTimedBlockBonus;
    public static ConfigEntry<float> _claymoreSlashDmg;
    public static ConfigEntry<float> _claymoreAttackForce;
    public static ConfigEntry<float> _daggerSlashDmg;
    public static ConfigEntry<float> _daggerPierceDmg;
    public static ConfigEntry<float> _daggerAttackForce;
    public static ConfigEntry<float> _darkSwordSlashDmg;
    public static ConfigEntry<float> _darkSwordFireDmg;
    public static ConfigEntry<float> _darkSwordAttackForce;
    public static ConfigEntry<float> _draconicDaggerSlashDmg;
    public static ConfigEntry<float> _draconicDaggerPierceDmg;
    public static ConfigEntry<float> _draconicDaggerFrostDmg;
    public static ConfigEntry<float> _draconicDaggerAttackForce;
    public static ConfigEntry<float> _draconicGreatswordSlashDmg;
    public static ConfigEntry<float> _draconicGreatswordFrostDmg;
    public static ConfigEntry<float> _draconicGreatswordAttackForce;
    public static ConfigEntry<float> _draconicScytheSlashDmg;
    public static ConfigEntry<float> _draconicScytheChopDmg;
    public static ConfigEntry<float> _draconicScytheFrostDmg;
    public static ConfigEntry<float> _draconicScytheAttackForce;
    public static ConfigEntry<float> _draconicSwordSlashDmg;
    public static ConfigEntry<float> _draconicSwordFrostDmg;
    public static ConfigEntry<float> _draconicSwordAttackForce;
    public static ConfigEntry<float> _dragonBladeSlashDmg;
    public static ConfigEntry<float> _dragonBladeFrostDmg;
    public static ConfigEntry<float> _dragonBladeAttackForce;
    public static ConfigEntry<float> _elvenAxeSlashDmg;
    public static ConfigEntry<float> _elvenAxeChopDmg;
    public static ConfigEntry<float> _elvenAxeLightningDmg;
    public static ConfigEntry<float> _elvenAxeAttackForce;
    public static ConfigEntry<float> _elvenBowPierceDmg;
    public static ConfigEntry<float> _elvenBowLightningDmg;
    public static ConfigEntry<float> _elvenBowAttackForce;
    public static ConfigEntry<float> _elvenHammerBluntDmg;
    public static ConfigEntry<float> _elvenHammerLightningDmg;
    public static ConfigEntry<float> _elvenHammerAttackForce;
    public static ConfigEntry<float> _elvenShieldBlockPower;
    public static ConfigEntry<float> _elvenShieldDeflectionForce;
    public static ConfigEntry<float> _elvenShieldTimedBlockBonus;
    public static ConfigEntry<float> _elvenSpearPierceDmg;
    public static ConfigEntry<float> _elvenSpearLightningDmg;
    public static ConfigEntry<float> _elvenSpearAttackForce;
    public static ConfigEntry<float> _elvenSwordSlashDmg;
    public static ConfigEntry<float> _elvenSwordLightningDmg;
    public static ConfigEntry<float> _elvenSwordAttackForce;
    public static ConfigEntry<float> _flameMetalGreatswordSlashDmg;
    public static ConfigEntry<float> _flameMetalGreatswordFireDmg;
    public static ConfigEntry<float> _flameMetalGreatswordAttackForce;
    public static ConfigEntry<float> _flameMetalHammerBluntDmg;
    public static ConfigEntry<float> _flameMetalHammerFireDmg;
    public static ConfigEntry<float> _flameMetalHammerAttackForce;
    public static ConfigEntry<float> _flameMetalSwordSlashDmg;
    public static ConfigEntry<float> _flameMetalSwordFireDmg;
    public static ConfigEntry<float> _flameMetalSwordAttackForce;
    public static ConfigEntry<float> _giantAxeSlashDmg;
    public static ConfigEntry<float> _giantAxeChopDmg;
    public static ConfigEntry<float> _giantAxeAttackForce;
    public static ConfigEntry<float> _giantMaceBluntDmg;
    public static ConfigEntry<float> _giantMaceSlashDmg;
    public static ConfigEntry<float> _giantMaceAttackForce;
    public static ConfigEntry<float> _greatswordSlashDmg;
    public static ConfigEntry<float> _greatswordAttackForce;
    public static ConfigEntry<float> _dragonBoneGreatswordBluntDmg;
    public static ConfigEntry<float> _dragonBoneGreatswordAttackForce;
    public static ConfigEntry<float> _dragonBoneGreatswordPierceDmg;
    public static ConfigEntry<float> _ironSpikedMaceBluntDmg;
    public static ConfigEntry<float> _ironSpikedMacePierceDmg;
    public static ConfigEntry<float> _ironSpikedMaceAttackForce;
    public static ConfigEntry<float> _obsidianBucklerBlockPower;
    public static ConfigEntry<float> _obsidianBucklerDeflectionForce;
    public static ConfigEntry<float> _obsidianBucklerTimedBlockBonus;
    public static ConfigEntry<float> _obsidianGreatswordSlashDmg;
    public static ConfigEntry<float> _obsidianGreatswordAttackForce;
    public static ConfigEntry<float> _poisonousSpikedMaceBluntDmg;
    public static ConfigEntry<float> _poisonousSpikedMacePierceDmg;
    public static ConfigEntry<float> _poisonousSpikedMacePoisonDmg;
    public static ConfigEntry<float> _poisonousSpikedMaceAttackForce;
    public static ConfigEntry<float> _seekerBowPierceDmg;
    public static ConfigEntry<float> _seekerBowFireDmg;
    public static ConfigEntry<float> _seekerBowAttackForce;
    public static ConfigEntry<float> _silverAxeSlashDmg;
    public static ConfigEntry<float> _silverAxeChopDmg;
    public static ConfigEntry<float> _silverAxeAttackForce;
    public static ConfigEntry<float> _tulwarSlashDmg;
    public static ConfigEntry<float> _tulwarAttackForce;

    public static void Init()
    {
        BattleHammer();
        BlackMetalSpear();
        Broadsword();
        BronzeBattleAxe();
        BronzeChainBuckler();
        BronzeHammer();
        BronzeMace();
        ChainBuckler();
        Claymore();
        Dagger();
        DarkSword();
        DraconicDagger();
        DraconicGreatsword();
        DraconicScythe();
        DraconicSword();
        DragonBlade();
        DragonBoneGreatsword();
        ElvenAxe();
        ElvenBow();
        ElvenHammer();
        ElvenShield();
        ElvenSpear();
        ElvenSword();
        FlametalGreatsword();
        FlametalHammer();
        FlametalSword();
        GiantAxe();
        GiantMace();
        Greatsword();
        IronSpikedMace();
        ObsidianBuckler();
        ObsidianGreatsword();
        PoisonousSpikedMace();
        SeekerBow();
        SilverAxe();
        Tulwar();
    }

    private static void BattleHammer()
    {
        var name = Helper.Localize("$bwa_battlehammer");
        _battleHammerAttackForce = Plugin._Instance.config(name, "Attack Force", 200f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 300f)));
        _battleHammerBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 55f, new ConfigDescription(
            "Base blunt damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void BlackMetalSpear()
    {
        var name = Helper.Localize("$bwa_blackmetalspear");
        _blackMetalSpearAttackForce = Plugin._Instance.config(name, "Attack Force", 30f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _blackMetalSpearPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 105f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 150f)));
    }
    
    private static void Broadsword()
    {
        var name = Helper.Localize("$bwa_broadsword");
        _broadswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _broadswordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 75f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
        _broadswordSpiritDmg =
            Plugin._Instance.config(name, "Spirit Damage", 40f, new ConfigDescription("Base spirit damage.",
                new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
    }

    private static void BronzeBattleAxe()
    {
        var name = Helper.Localize("$bwa_bronzebattleaxe");
        _bronzeBattleAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 60f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _bronzeBattleAxeChopDmg = Plugin._Instance.config(name, "Chop Damage", 20f,
            new ConfigDescription("Base chop damage.", new AcceptableValueRange<float>(0f, 50f)));
        _bronzeBattleAxeSlashDmg = Plugin._Instance.config(name, "Slash Damage", 48f, new ConfigDescription(
            "Base slash damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void BronzeChainBuckler()
    {
        var name = Helper.Localize("$bwa_bronze_chainbuckler");
        _bronzeChainBucklerBlockPower = Plugin._Instance.config(name, "Block Power", 16f,
            new ConfigDescription("Base block power.", new AcceptableValueRange<float>(0f, 30f)));
        _bronzeChainBucklerDeflectionForce = Plugin._Instance.config(name, "Deflection Force", 30f,
            new ConfigDescription("Base deflection force.", new AcceptableValueRange<float>(0f, 50f)));
        _bronzeChainBucklerTimedBlockBonus = Plugin._Instance.config(name, "Timed Block Bonus", 2.5f,
            new ConfigDescription(string.Empty, new AcceptableValueRange<float>(0.0f, 5.0f)));
    }

    private static void BronzeHammer()
    {
        var name = Helper.Localize("$bwa_bronzehammer");
        _bronzeHammerAttackForce = Plugin._Instance.config(name, "Attack Force", 165f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 200f)));
        _bronzeHammerBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 45f,
            new ConfigDescription("Base blunt damage.", new AcceptableValueRange<float>(0f, 100f),
                new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
    }

    private static void BronzeMace()
    {
        var name = Helper.Localize("$bwa_bronzemace");
        _bronzeMaceAttackForce = Plugin._Instance.config(name, "Attack Force", 90f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 150f)));
        _bronzeMaceBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 46f, new ConfigDescription(
            "Base blunt damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void ChainBuckler()
    {
        var name = Helper.Localize("$bwa_chainbuckler");
        _chainBucklerBlockPower = Plugin._Instance.config(name, "Block Power", 28f,
            new ConfigDescription("Base block power.", new AcceptableValueRange<float>(0f, 50f)));
        _chainBucklerDeflectionForce = Plugin._Instance.config(name, "Deflection Force", 30f,
            new ConfigDescription("Base deflection force.", new AcceptableValueRange<float>(0f, 50f)));
        _chainBucklerTimedBlockBonus = Plugin._Instance.config(name, "Timed Block Bonus", 2.5f,
            new ConfigDescription(string.Empty, new AcceptableValueRange<float>(0f, 5f)));
    }
    
    private static void Claymore()
    {
        var name = Helper.Localize("$bwa_claymore");
        _claymoreAttackForce = Plugin._Instance.config(name, "Attack Force", 45f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _claymoreSlashDmg = Plugin._Instance.config(name, "Slash Damage", 90f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }

    private static void Dagger()
    {
        var name = Helper.Localize("$bwa_dagger");
        _daggerAttackForce = Plugin._Instance.config(name, "Attack Force", 15f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 30f)));
        _daggerPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 24f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 50f)));
        _daggerSlashDmg = Plugin._Instance.config(name, "Slash Damage", 24f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 50f)));
    }

    private static void DarkSword()
    {
        var name = Helper.Localize("$bwa_darksword");
        _darkSwordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 80f)));
        _darkSwordFireDmg = Plugin._Instance.config(name, "Fire Damage", 32f,
            new ConfigDescription("Base fire damage.", new AcceptableValueRange<float>(0f, 50f)));
        _darkSwordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 75f, new ConfigDescription(
            "Base slash damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void DraconicDagger()
    {
        var name = Helper.Localize("$bwa_draconic_dagger");
        _draconicDaggerAttackForce = Plugin._Instance.config(name, "Attack Force", 10f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 25f)));
        _draconicDaggerFrostDmg = Plugin._Instance.config(name, "Frost Damage", 40f,
            new ConfigDescription("Base frost damage.", new AcceptableValueRange<float>(0f, 80f)));
        _draconicDaggerPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 29f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 50f)));
        _draconicDaggerSlashDmg = Plugin._Instance.config(name, "Slash Damage", 29f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 50f)));
    }

    private static void DraconicGreatsword()
    {
        var name = Helper.Localize("$bwa_draconic_greatsword");
        _draconicGreatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 45f,
            new ConfigDescription("Base attack force", new AcceptableValueRange<float>(0f, 90f)));
        _draconicGreatswordFrostDmg = Plugin._Instance.config(name, "Frost Damage", 40f,
            new ConfigDescription("Base frost damage.", new AcceptableValueRange<float>(0f, 80f)));
        _draconicGreatswordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 96f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 150f)));
    }

    private static void DraconicScythe()
    {
        var name = Helper.Localize("$bwa_draconicscythe");
        _draconicScytheAttackForce = Plugin._Instance.config(name, "Attack Force", 70f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 140f)));
        _draconicScytheChopDmg = Plugin._Instance.config(name, "Chop Damage", 60f, new ConfigDescription(
            "Base chop damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _draconicScytheFrostDmg = Plugin._Instance.config(name, "Frost Damage", 40f,
            new ConfigDescription("Base frost damage.", new AcceptableValueRange<float>(0f, 80f)));
        _draconicScytheSlashDmg = Plugin._Instance.config(name, "Slash Damage", 90f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }

    private static void DraconicSword()
    {
        var name = Helper.Localize("$bwa_draconicsword");
        _draconicSwordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 80f)));
        _draconicSwordFrostDmg = Plugin._Instance.config(name, "Frost Damage", 40f,
            new ConfigDescription("Base frost damage.", new AcceptableValueRange<float>(0f, 80f)));
        _draconicSwordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 75f, new ConfigDescription(
            "Base slash damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void DragonBlade()
    {
        var name = Helper.Localize("$bwa_dragonblade");
        _dragonBladeAttackForce = Plugin._Instance.config(name, "Attack Force", 45f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 90f)));
        _dragonBladeFrostDmg = Plugin._Instance.config(name, "Frost Damage", 22f,
            new ConfigDescription("Base frost damage.", new AcceptableValueRange<float>(0f, 50f)));
        _dragonBladeSlashDmg = Plugin._Instance.config(name, "Slash Damage", 88f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }

    private static void DragonBoneGreatsword()
    {
        var name = Helper.Localize("$bwa_dragonbone_greatsword");
        _dragonBoneGreatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force", new AcceptableValueRange<float>(0f, 80f)));
        _dragonBoneGreatswordPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 22f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 50f)));
        _dragonBoneGreatswordBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 74f, new ConfigDescription(
            "Base blunt damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void ElvenAxe()
    {
        var name = Helper.Localize("$bwa_elvenaxe");
        _elvenAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 100f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 150f)));
        _elvenAxeChopDmg = Plugin._Instance.config(name, "Chop Damage", 50f, new ConfigDescription("Base chop damage.",
            new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenAxeLightningDmg = Plugin._Instance.config(name, "Lightning Damage", 60f, new ConfigDescription(
            "Base lightning damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenAxeSlashDmg = Plugin._Instance.config(name, "Slash Damage", 100f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 150f)));
    }

    private static void ElvenBow()
    {
        var name = Helper.Localize("$bwa_elvenbow");
        _elvenBowAttackForce = Plugin._Instance.config(name, "Attack Force", 25f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 50f)));
        _elvenBowLightningDmg = Plugin._Instance.config(name, "Lightning Damage", 60f, new ConfigDescription(
            "Base lightning damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenBowPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 72f, new ConfigDescription(
            "Base pierce damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void ElvenHammer()
    {
        var name = Helper.Localize("$bwa_elvenhammer");
        _elvenHammerAttackForce = Plugin._Instance.config(name, "Attack Force", 210f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 250f)));
        _elvenHammerBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 125f,
            new ConfigDescription("Base blunt damage.", new AcceptableValueRange<float>(0f, 150f)));
        _elvenHammerLightningDmg = Plugin._Instance.config(name, "Lightning Damage", 60f, new ConfigDescription(
            "Base lightning damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }

    private static void ElvenShield()
    {
        var name = Helper.Localize("$bwa_elvenshield");
        _elvenShieldBlockPower = Plugin._Instance.config(name, "Block Power", 96f,
            new ConfigDescription("Base block power.", new AcceptableValueRange<float>(0f, 120f)));
        _elvenShieldDeflectionForce = Plugin._Instance.config(name, "Deflection Force", 60f, new ConfigDescription(
            "Base deflection force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenShieldTimedBlockBonus = Plugin._Instance.config(name, "Timed Block Bonus", 1.5f,
            new ConfigDescription(string.Empty, new AcceptableValueRange<float>(0f, 5f)));
    }

    private static void ElvenSpear()
    {
        var name = Helper.Localize("$bwa_elvenspear");
        _elvenSpearAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 80f)));
        _elvenSpearLightningDmg = Plugin._Instance.config(name, "Lightning Damage", 60f, new ConfigDescription(
            "Base lightning damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenSpearPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 115f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 150f)));
    }

    private static void ElvenSword()
    {
        var name = Helper.Localize("$bwa_elvensword");
        _elvenSwordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 80f)));
        _elvenSwordLightningDmg = Plugin._Instance.config(name, "Lightning Damage", 60f, new ConfigDescription(
            "Base lightning damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _elvenSwordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 85f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }

    private static void FlametalGreatsword()
    {
        var name = Helper.Localize("$bwa_flametal_greatsword");
        _flameMetalGreatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 60f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _flameMetalGreatswordFireDmg = Plugin._Instance.config(name, "Fire Damage", 100f,
            new ConfigDescription("Base fire damage.", new AcceptableValueRange<float>(0f, 150f)));
        _flameMetalGreatswordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 176f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 200f)));
    }

    private static void FlametalHammer()
    {
        var name = Helper.Localize("$bwa_flametal_hammer");
        _flameMetalHammerAttackForce = Plugin._Instance.config(name, "Attack Force", 250f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 300f)));
        _flameMetalHammerBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 165f,
            new ConfigDescription("Base blunt damage.", new AcceptableValueRange<float>(0f, 200f)));
        _flameMetalHammerFireDmg = Plugin._Instance.config(name, "Fire Damage", 100f,
            new ConfigDescription("Base fire damage.", new AcceptableValueRange<float>(0f, 150f)));
    }

    private static void FlametalSword()
    {
        var name = Helper.Localize("$bwa_flametal_sword");
        _flameMetalSwordAttackForce = Plugin._Instance.config(name, "Attack Force", 50f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _flameMetalSwordFireDmg = Plugin._Instance.config(name, "Fire Damage", 100f,
            new ConfigDescription("Base fire damage.", new AcceptableValueRange<float>(0f, 150f)));
        _flameMetalSwordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 105f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 150f)));
    }
    
    private static void GiantAxe()
    {
        var name = Helper.Localize("$bwa_giantaxe");
        _giantAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 80f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _giantAxeChopDmg = Plugin._Instance.config(name, "Chop Damage", 60f,
            new ConfigDescription("Base chop damage.", new AcceptableValueRange<float>(0f, 100f),
                new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
        _giantAxeSlashDmg = Plugin._Instance.config(name, "Slash Damage", 120f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 150f)));
    }
    
    private static void GiantMace()
    {
        var name = Helper.Localize("$bwa_giantmace");
        _giantMaceAttackForce = Plugin._Instance.config(name, "Attack Force", 90f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 150f)));
        _giantMaceBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 40f,
            new ConfigDescription("Base blunt damage.", new AcceptableValueRange<float>(0f, 50f)));
        _giantMaceSlashDmg = Plugin._Instance.config(name, "Slash Damage", 16f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 30f)));
    }
    
    private static void Greatsword()
    {
        var name = Helper.Localize("$bwa_greatsword");
        _greatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _greatswordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 65f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 100f),
                new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
    }

    private static void IronSpikedMace()
    {
        var name = Helper.Localize("$bwa_ironspiked_mace");
        _ironSpikedMaceAttackForce = Plugin._Instance.config(name, "Attack Force", 90f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 120f)));
        _ironSpikedMaceBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 48f, new ConfigDescription(
            "Base blunt damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _ironSpikedMacePierceDmg = Plugin._Instance.config(name, "Pierce Damage", 23f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 50f)));
    }

    private static void ObsidianBuckler()
    {
        var name = Helper.Localize("$bwa_obsidianbuckler");
        _obsidianBucklerBlockPower = Plugin._Instance.config(name, "Block Power", 60f, new ConfigDescription(
            "Base block power.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _obsidianBucklerDeflectionForce = Plugin._Instance.config(name, "Deflection Force", 40f,
            new ConfigDescription("Base deflection force.", new AcceptableValueRange<float>(0f, 80f)));
        _obsidianBucklerTimedBlockBonus = Plugin._Instance.config(name, "Timed Block Bonus", 1.5f,
            new ConfigDescription(string.Empty, new AcceptableValueRange<float>(0f, 5f)));
    }

    private static void ObsidianGreatsword()
    {
        var name = Helper.Localize("$bwa_obsidian_greatsword");
        _obsidianGreatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 80f)));
        _obsidianGreatswordSlashDmg = Plugin._Instance.config(name, "Slash Damage", 98f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }

    private static void PoisonousSpikedMace()
    {
        var name = Helper.Localize("$bwa_poisonousspiked_mace");
        _poisonousSpikedMaceAttackForce = Plugin._Instance.config(name, "Attack Force", 90f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 120f)));
        _poisonousSpikedMaceBluntDmg = Plugin._Instance.config(name, "Blunt Damage", 48f, new ConfigDescription(
            "Base blunt damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _poisonousSpikedMacePierceDmg = Plugin._Instance.config(name, "Pierce Damage", 23f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(0f, 50f)));
        _poisonousSpikedMacePoisonDmg = Plugin._Instance.config(name, "Poison Damage", 18f,
            new ConfigDescription("Base poison damage.", new AcceptableValueRange<float>(0f, 50f)));
    }

    private static void SeekerBow()
    {
        var name = Helper.Localize("$bwa_seekerbow");
        _seekerBowAttackForce = Plugin._Instance.config(name, "Attack Force", 25f,
            new ConfigDescription("Base attack force.", new AcceptableValueRange<float>(0f, 50f)));
        _seekerBowFireDmg = Plugin._Instance.config(name, "Fire Damage", 60f, new ConfigDescription("Base fire damage.",
            new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _seekerBowPierceDmg = Plugin._Instance.config(name, "Pierce Damage", 72f, new ConfigDescription(
            "Base pierce damage.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
    }
    
    private static void SilverAxe()
    {
        var name = Helper.Localize("$bwa_silveraxe");
        _silverAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 55f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _silverAxeChopDmg = Plugin._Instance.config(name, "Chop Damage", 55f,
            new ConfigDescription("Base chop damage.", new AcceptableValueRange<float>(0f, 150f)));
        _silverAxeSlashDmg = Plugin._Instance.config(name, "Slash Damage", 80f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 120f)));
    }
    
    private static void Tulwar()
    {
        var name = Helper.Localize("$bwa_tulwar");
        _tulwarAttackForce = Plugin._Instance.config(name, "Attack Force", 50f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _tulwarSlashDmg = Plugin._Instance.config(name, "Slash Damage", 120f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(0f, 200f)));
    }
}