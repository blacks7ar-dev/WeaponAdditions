namespace WeaponAdditions.Functions;

public static class StatsSetup
{
    public static void BattleHammer(ItemDrop item)
    {
        ConfigSetup._battleHammerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._battleHammerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._battleHammerAttackForce.Value;
        ConfigSetup._battleHammerBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._battleHammerBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._battleHammerBluntDmg.Value;
    }
    
    public static void BlackMetalSpear(ItemDrop item)
    {
        ConfigSetup._blackMetalSpearAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._blackMetalSpearAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._blackMetalSpearAttackForce.Value;
        ConfigSetup._blackMetalSpearPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._blackMetalSpearPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._blackMetalSpearPierceDmg.Value;
    }
    
    public static void Broadsword(ItemDrop item)
    {
        ConfigSetup._broadswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._broadswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._broadswordAttackForce.Value;
        ConfigSetup._broadswordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._broadswordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._broadswordSlashDmg.Value;
        ConfigSetup._broadswordSpiritDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_spirit = ConfigSetup._broadswordSpiritDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_spirit = ConfigSetup._broadswordSpiritDmg.Value;
    }

    public static void BronzeBattleAxe(ItemDrop item)
    {
        ConfigSetup._bronzeBattleAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeBattleAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeBattleAxeAttackForce.Value;
        ConfigSetup._bronzeBattleAxeChopDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._bronzeBattleAxeChopDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._bronzeBattleAxeChopDmg.Value;
        ConfigSetup._bronzeBattleAxeSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._bronzeBattleAxeSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._bronzeBattleAxeSlashDmg.Value;
    }

    public static void BronzeChainBuckler(ItemDrop item)
    {
        ConfigSetup._bronzeChainBucklerBlockPower.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_blockPower = ConfigSetup._bronzeChainBucklerBlockPower.Value;
        };
        item.m_itemData.m_shared.m_blockPower = ConfigSetup._bronzeChainBucklerBlockPower.Value;
        ConfigSetup._bronzeChainBucklerDeflectionForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._bronzeChainBucklerDeflectionForce.Value;
        };
        item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._bronzeChainBucklerDeflectionForce.Value;
        ConfigSetup._bronzeChainBucklerTimedBlockBonus.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._bronzeChainBucklerTimedBlockBonus.Value;
        };
        item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._bronzeChainBucklerTimedBlockBonus.Value;
    }

    public static void BronzeHammer(ItemDrop item)
    {
        ConfigSetup._bronzeHammerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeHammerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeHammerAttackForce.Value;
        ConfigSetup._bronzeHammerBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._bronzeHammerBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._bronzeHammerBluntDmg.Value;
    }

    public static void BronzeMace(ItemDrop item)
    {
        ConfigSetup._bronzeMaceAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeMaceAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._bronzeMaceAttackForce.Value;
        ConfigSetup._bronzeMaceBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._bronzeMaceBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._bronzeMaceBluntDmg.Value;
    }

    public static void ChainBuckler(ItemDrop item)
    {
        ConfigSetup._chainBucklerBlockPower.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_blockPower = ConfigSetup._chainBucklerBlockPower.Value;
        };
        item.m_itemData.m_shared.m_blockPower = ConfigSetup._chainBucklerBlockPower.Value;
        ConfigSetup._chainBucklerDeflectionForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._chainBucklerDeflectionForce.Value;
        };
        item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._chainBucklerDeflectionForce.Value;
        ConfigSetup._chainBucklerTimedBlockBonus.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._chainBucklerTimedBlockBonus.Value;
        };
        item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._chainBucklerTimedBlockBonus.Value;
    }
    
    public static void Claymore(ItemDrop item)
    {
        ConfigSetup._claymoreAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._claymoreAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._claymoreAttackForce.Value;
        ConfigSetup._claymoreSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._claymoreSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._claymoreSlashDmg.Value;
    }

    public static void Dagger(ItemDrop item)
    {
        ConfigSetup._daggerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._daggerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._daggerAttackForce.Value;
        ConfigSetup._daggerPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._daggerPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._daggerPierceDmg.Value;
        ConfigSetup._daggerSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._daggerSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._daggerSlashDmg.Value;
    }

    public static void DarkSword(ItemDrop item)
    {
        ConfigSetup._darkSwordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._darkSwordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._darkSwordAttackForce.Value;
        ConfigSetup._darkSwordFireDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._darkSwordFireDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._darkSwordFireDmg.Value;
        ConfigSetup._darkSwordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._darkSwordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._darkSwordSlashDmg.Value;
    }

    public static void DraconicDagger(ItemDrop item)
    {
        ConfigSetup._draconicDaggerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicDaggerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicDaggerAttackForce.Value;
        ConfigSetup._draconicDaggerFrostDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicDaggerFrostDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicDaggerFrostDmg.Value;
        ConfigSetup._draconicDaggerPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._draconicDaggerPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._draconicDaggerPierceDmg.Value;
        ConfigSetup._draconicDaggerSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicDaggerSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicDaggerSlashDmg.Value;
    }

    public static void DraconicGreatsword(ItemDrop item)
    {
        ConfigSetup._draconicGreatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicGreatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicGreatswordAttackForce.Value;
        ConfigSetup._draconicGreatswordFrostDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicGreatswordFrostDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicGreatswordFrostDmg.Value;
        ConfigSetup._draconicGreatswordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicGreatswordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicGreatswordSlashDmg.Value;
    }

    public static void DraconicScythe(ItemDrop item)
    {
        ConfigSetup._draconicScytheAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicScytheAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicScytheAttackForce.Value;
        ConfigSetup._draconicScytheChopDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._draconicScytheChopDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._draconicScytheChopDmg.Value;
        ConfigSetup._draconicScytheFrostDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicScytheFrostDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicScytheFrostDmg.Value;
        ConfigSetup._draconicScytheSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicScytheSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicScytheSlashDmg.Value;
    }

    public static void DraconicSword(ItemDrop item)
    {
        ConfigSetup._draconicSwordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicSwordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._draconicSwordAttackForce.Value;
        ConfigSetup._draconicSwordFrostDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicSwordFrostDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._draconicSwordFrostDmg.Value;
        ConfigSetup._draconicSwordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicSwordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._draconicSwordSlashDmg.Value;
    }

    public static void DragonBlade(ItemDrop item)
    {
        ConfigSetup._dragonBladeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._dragonBladeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._dragonBladeAttackForce.Value;
        ConfigSetup._dragonBladeFrostDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._dragonBladeFrostDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_frost = ConfigSetup._dragonBladeFrostDmg.Value;
        ConfigSetup._dragonBladeSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._dragonBladeSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._dragonBladeSlashDmg.Value;
    }

    public static void ElvenAxe(ItemDrop item)
    {
        ConfigSetup._elvenAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenAxeAttackForce.Value;
        ConfigSetup._elvenAxeChopDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._elvenAxeChopDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._elvenAxeChopDmg.Value;
        ConfigSetup._elvenAxeLightningDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenAxeLightningDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenAxeLightningDmg.Value;
        ConfigSetup._elvenAxeSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._elvenAxeSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._elvenAxeSlashDmg.Value;
    }

    public static void ElvenBow(ItemDrop item)
    {
        ConfigSetup._elvenBowAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenBowAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenBowAttackForce.Value;
        ConfigSetup._elvenBowLightningDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenBowLightningDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenBowLightningDmg.Value;
        ConfigSetup._elvenBowPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._elvenBowPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._elvenBowPierceDmg.Value;
    }

    public static void ElvenHammer(ItemDrop item)
    {
        ConfigSetup._elvenHammerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenHammerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenHammerAttackForce.Value;
        ConfigSetup._elvenHammerBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._elvenHammerBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._elvenHammerBluntDmg.Value;
        ConfigSetup._elvenHammerLightningDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenHammerLightningDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenHammerLightningDmg.Value;
    }

    public static void ElvenShield(ItemDrop item)
    {
        ConfigSetup._elvenShieldBlockPower.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_blockPower = ConfigSetup._elvenShieldBlockPower.Value;
        };
        item.m_itemData.m_shared.m_blockPower = ConfigSetup._elvenShieldBlockPower.Value;
        ConfigSetup._elvenShieldDeflectionForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._elvenShieldDeflectionForce.Value;
        };
        item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._elvenShieldDeflectionForce.Value;
        ConfigSetup._elvenShieldTimedBlockBonus.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._elvenShieldTimedBlockBonus.Value;
        };
        item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._elvenShieldTimedBlockBonus.Value;
    }

    public static void ElvenSpear(ItemDrop item)
    {
        ConfigSetup._elvenSpearAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenSpearAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenSpearAttackForce.Value;
        ConfigSetup._elvenSpearLightningDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenSpearLightningDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenSpearLightningDmg.Value;
        ConfigSetup._elvenSpearPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._elvenSpearPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._elvenSpearPierceDmg.Value;
    }

    public static void ElvenSword(ItemDrop item)
    {
        ConfigSetup._elvenSwordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenSwordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._elvenSwordAttackForce.Value;
        ConfigSetup._elvenSwordLightningDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenSwordLightningDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_lightning = ConfigSetup._elvenSwordLightningDmg.Value;
        ConfigSetup._elvenSwordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._elvenSwordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._elvenSwordSlashDmg.Value;
    }

    public static void FlametalGreatsword(ItemDrop item)
    {
        ConfigSetup._flameMetalGreatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalGreatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalGreatswordAttackForce.Value;
        ConfigSetup._flameMetalGreatswordFireDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalGreatswordFireDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalGreatswordFireDmg.Value;
        ConfigSetup._flameMetalGreatswordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._flameMetalGreatswordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._flameMetalGreatswordSlashDmg.Value;
    }

    public static void FlametalHammer(ItemDrop item)
    {
        ConfigSetup._flameMetalHammerAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalHammerAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalHammerAttackForce.Value;
        ConfigSetup._flameMetalHammerBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._flameMetalHammerBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._flameMetalHammerBluntDmg.Value;
        ConfigSetup._flameMetalHammerFireDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalHammerFireDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalHammerFireDmg.Value;
    }

    public static void FlametalSword(ItemDrop item)
    {
        ConfigSetup._flameMetalSwordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalSwordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._flameMetalSwordAttackForce.Value;
        ConfigSetup._flameMetalSwordFireDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalSwordFireDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._flameMetalSwordFireDmg.Value;
        ConfigSetup._flameMetalSwordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._flameMetalSwordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._flameMetalSwordSlashDmg.Value;
    }
    
    public static void GiantAxe(ItemDrop item)
    {
        ConfigSetup._giantAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantAxeAttackForce.Value;
        ConfigSetup._giantAxeChopDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._giantAxeChopDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._giantAxeChopDmg.Value;
        ConfigSetup._giantAxeSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantAxeSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantAxeSlashDmg.Value;
    }
    
    public static void GiantMace(ItemDrop item)
    {
        ConfigSetup._giantMaceAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantMaceAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantMaceAttackForce.Value;
        ConfigSetup._giantMaceBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._giantMaceBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._giantMaceBluntDmg.Value;
        ConfigSetup._giantMaceSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantMaceSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantMaceSlashDmg.Value;
    }
    
    public static void Greatsword(ItemDrop item)
    {
        ConfigSetup._greatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._greatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._greatswordAttackForce.Value;
        ConfigSetup._greatswordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._greatswordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._greatswordSlashDmg.Value;
    }

    public static void DragonBoneGreatsword(ItemDrop item)
    {
        ConfigSetup._dragonBoneGreatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._dragonBoneGreatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._dragonBoneGreatswordAttackForce.Value;
        ConfigSetup._dragonBoneGreatswordBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._dragonBoneGreatswordBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._dragonBoneGreatswordBluntDmg.Value;
        ConfigSetup._dragonBoneGreatswordPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._dragonBoneGreatswordPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._dragonBoneGreatswordPierceDmg.Value;
    }

    public static void IronSpikedMace(ItemDrop item)
    {
        ConfigSetup._ironSpikedMaceAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._ironSpikedMaceAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._ironSpikedMaceAttackForce.Value;
        ConfigSetup._ironSpikedMaceBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._ironSpikedMaceBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._ironSpikedMaceBluntDmg.Value;
        ConfigSetup._ironSpikedMacePierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._ironSpikedMacePierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._ironSpikedMacePierceDmg.Value;
    }

    public static void ObsidianBuckler(ItemDrop item)
    {
        ConfigSetup._obsidianBucklerBlockPower.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_blockPower = ConfigSetup._obsidianBucklerBlockPower.Value;
        };
        item.m_itemData.m_shared.m_blockPower = ConfigSetup._obsidianBucklerBlockPower.Value;
        ConfigSetup._obsidianBucklerDeflectionForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._obsidianBucklerDeflectionForce.Value;
        };
        item.m_itemData.m_shared.m_deflectionForce = ConfigSetup._obsidianBucklerDeflectionForce.Value;
        ConfigSetup._obsidianBucklerTimedBlockBonus.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._obsidianBucklerTimedBlockBonus.Value;
        };
        item.m_itemData.m_shared.m_timedBlockBonus = ConfigSetup._obsidianBucklerTimedBlockBonus.Value;
    }

    public static void ObsidianGreatsword(ItemDrop item)
    {
        ConfigSetup._obsidianGreatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._obsidianGreatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._obsidianGreatswordAttackForce.Value;
        ConfigSetup._obsidianGreatswordSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._obsidianGreatswordSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._obsidianGreatswordSlashDmg.Value;
    }

    public static void PoisonousSpikedMace(ItemDrop item)
    {
        ConfigSetup._poisonousSpikedMaceAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._poisonousSpikedMaceAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._poisonousSpikedMaceAttackForce.Value;
        ConfigSetup._poisonousSpikedMaceBluntDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._poisonousSpikedMaceBluntDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._poisonousSpikedMaceBluntDmg.Value;
        ConfigSetup._poisonousSpikedMacePierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._poisonousSpikedMacePierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._poisonousSpikedMacePierceDmg.Value;
        ConfigSetup._poisonousSpikedMacePoisonDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_poison = ConfigSetup._poisonousSpikedMacePoisonDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_poison = ConfigSetup._poisonousSpikedMacePoisonDmg.Value;
    }

    public static void SeekerBow(ItemDrop item)
    {
        ConfigSetup._seekerBowAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._seekerBowAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._seekerBowAttackForce.Value;
        ConfigSetup._seekerBowFireDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._seekerBowFireDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_fire = ConfigSetup._seekerBowFireDmg.Value;
        ConfigSetup._seekerBowPierceDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._seekerBowPierceDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._seekerBowPierceDmg.Value;
    }
    
    public static void SilverAxe(ItemDrop item)
    {
        ConfigSetup._silverAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._silverAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._silverAxeAttackForce.Value;
        ConfigSetup._silverAxeChopDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._silverAxeChopDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._silverAxeChopDmg.Value;
        ConfigSetup._silverAxeSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._silverAxeSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._silverAxeSlashDmg.Value;
    }
    
    public static void Tulwar(ItemDrop item)
    {
        ConfigSetup._tulwarAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._tulwarAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._tulwarAttackForce.Value;
        ConfigSetup._tulwarSlashDmg.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._tulwarSlashDmg.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._tulwarSlashDmg.Value;
    }
}