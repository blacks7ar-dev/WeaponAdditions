namespace WeaponAdditions.Functions;

public static class StatsSetup
{
    public static void Spear(ItemDrop item)
    {
        ConfigSetup._spearAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._spearAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._spearAttackForce.Value;
        ConfigSetup._spearPierceDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._spearPierceDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_pierce = ConfigSetup._spearPierceDamage.Value;
    }
    
    public static void Broadsword(ItemDrop item)
    {
        ConfigSetup._broadswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._broadswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._broadswordAttackForce.Value;
        ConfigSetup._broadswordSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._broadswordSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._broadswordSlashDamage.Value;
        ConfigSetup._broadswordSpiritDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_spirit = ConfigSetup._broadswordSpiritDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_spirit = ConfigSetup._broadswordSpiritDamage.Value;
    }
    
    public static void Claymore(ItemDrop item)
    {
        ConfigSetup._claymoreAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._claymoreAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._claymoreAttackForce.Value;
        ConfigSetup._claymoreSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._claymoreSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._claymoreSlashDamage.Value;
    }
    
    public static void GiantAxe(ItemDrop item)
    {
        ConfigSetup._giantAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantAxeAttackForce.Value;
        ConfigSetup._giantAxeChopDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._giantAxeChopDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._giantAxeChopDamage.Value;
        ConfigSetup._giantAxeSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantAxeSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantAxeSlashDamage.Value;
    }
    
    public static void GiantMace(ItemDrop item)
    {
        ConfigSetup._giantMaceAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantMaceAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._giantMaceAttackForce.Value;
        ConfigSetup._giantMaceBluntDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._giantMaceBluntDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_blunt = ConfigSetup._giantMaceBluntDamage.Value;
        ConfigSetup._giantMaceSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantMaceSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._giantMaceSlashDamage.Value;
    }
    
    public static void Greatsword(ItemDrop item)
    {
        ConfigSetup._greatswordAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._greatswordAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._greatswordAttackForce.Value;
        ConfigSetup._greatswordSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._greatswordSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._greatswordSlashDamage.Value;
    }
    
    public static void SilverAxe(ItemDrop item)
    {
        ConfigSetup._silverAxeAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._silverAxeAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._silverAxeAttackForce.Value;
        ConfigSetup._silverAxeChopDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._silverAxeChopDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_chop = ConfigSetup._silverAxeChopDamage.Value;
        ConfigSetup._silverAxeSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._silverAxeSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._silverAxeSlashDamage.Value;
    }
    
    public static void Tulwar(ItemDrop item)
    {
        ConfigSetup._tulwarAttackForce.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_attackForce = ConfigSetup._tulwarAttackForce.Value;
        };
        item.m_itemData.m_shared.m_attackForce = ConfigSetup._tulwarAttackForce.Value;
        ConfigSetup._tulwarSlashDamage.SettingChanged += delegate
        {
            item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._tulwarSlashDamage.Value;
        };
        item.m_itemData.m_shared.m_damages.m_slash = ConfigSetup._tulwarSlashDamage.Value;
    }
}