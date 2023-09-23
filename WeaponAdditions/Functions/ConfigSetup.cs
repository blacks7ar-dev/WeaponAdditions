using BepInEx.Configuration;
using WeaponAdditions.Utils;

namespace WeaponAdditions.Functions;

public static class ConfigSetup
{
    public static ConfigEntry<float> _spearPierceDamage;
    public static ConfigEntry<float> _spearAttackForce;
    public static ConfigEntry<bool> _spearEnable;
    public static ConfigEntry<string> _spearMat1;
    public static ConfigEntry<string> _spearMat2;
    public static ConfigEntry<string> _spearMat3;
    public static ConfigEntry<string> _spearMat4;
    public static ConfigEntry<float> _broadswordSlashDamage;
    public static ConfigEntry<float> _broadswordSpiritDamage;
    public static ConfigEntry<float> _broadswordAttackForce;
    public static ConfigEntry<bool> _broadswordEnable;
    public static ConfigEntry<string> _broadswordMat1;
    public static ConfigEntry<string> _broadswordMat2;
    public static ConfigEntry<string> _broadswordMat3;
    public static ConfigEntry<string> _broadswordMat4;
    public static ConfigEntry<float> _claymoreSlashDamage;
    public static ConfigEntry<float> _claymoreAttackForce;
    public static ConfigEntry<bool> _claymoreEnable;
    public static ConfigEntry<string> _claymoreMat1;
    public static ConfigEntry<string> _claymoreMat2;
    public static ConfigEntry<string> _claymoreMat3;
    public static ConfigEntry<string> _claymoreMat4;
    public static ConfigEntry<float> _giantAxeSlashDamage;
    public static ConfigEntry<float> _giantAxeChopDamage;
    public static ConfigEntry<float> _giantAxeAttackForce;
    public static ConfigEntry<bool> _giantAxeEnable;
    public static ConfigEntry<string> _giantAxeMat1;
    public static ConfigEntry<string> _giantAxeMat2;
    public static ConfigEntry<string> _giantAxeMat3;
    public static ConfigEntry<string> _giantAxeMat4;
    public static ConfigEntry<float> _giantMaceBluntDamage;
    public static ConfigEntry<float> _giantMaceSlashDamage;
    public static ConfigEntry<float> _giantMaceAttackForce;
    public static ConfigEntry<bool> _giantMaceEnable;
    public static ConfigEntry<string> _giantMaceMat1;
    public static ConfigEntry<string> _giantMaceMat2;
    public static ConfigEntry<string> _giantMaceMat3;
    public static ConfigEntry<string> _giantMaceMat4;
    public static ConfigEntry<float> _greatswordSlashDamage;
    public static ConfigEntry<float> _greatswordAttackForce;
    public static ConfigEntry<bool> _greatswordEnable;
    public static ConfigEntry<string> _greatswordMat1;
    public static ConfigEntry<string> _greatswordMat2;
    public static ConfigEntry<string> _greatswordMat3;
    public static ConfigEntry<string> _greatswordMat4;
    public static ConfigEntry<float> _silverAxeSlashDamage;
    public static ConfigEntry<float> _silverAxeChopDamage;
    public static ConfigEntry<float> _silverAxeAttackForce;
    public static ConfigEntry<bool> _silverAxeEnable;
    public static ConfigEntry<string> _silverAxeMat1;
    public static ConfigEntry<string> _silverAxeMat2;
    public static ConfigEntry<string> _silverAxeMat3;
    public static ConfigEntry<string> _silverAxeMat4;
    public static ConfigEntry<float> _tulwarSlashDamage;
    public static ConfigEntry<float> _tulwarAttackForce;
    public static ConfigEntry<bool> _tulwarEnable;
    public static ConfigEntry<string> _tulwarMat1;
    public static ConfigEntry<string> _tulwarMat2;
    public static ConfigEntry<string> _tulwarMat3;
    public static ConfigEntry<string> _tulwarMat4;

    private const string _enableDesc = "Enable/Disables recipe. (Needs Logout)";
    private const string _matName1 = "Required Material 1";
    private const string _matName2 = "Required Material 2";
    private const string _matName3 = "Required Material 3";
    private const string _matName4 = "Required Material 4";
    private const string _matDesc = "Item name : amount : amount per level (Needs Logout)";

    public static void Init()
    {
        Spear();
        Broadsword();
        Claymore();
        GiantAxe();
        GiantMace();
        Gretsword();
        SilverAxe();
        Tulwar();
    }

    private static void Spear()
    {
        var name = Helper.Localize("$bwa_blackmetalspear");
        _spearAttackForce = Plugin._Instance.config(name, "Attack Force", 30f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _spearPierceDamage = Plugin._Instance.config(name, "Pierce Damage", 105f,
            new ConfigDescription("Base pierce damage.", new AcceptableValueRange<float>(1f, 150f)));
        _spearEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _spearMat1 = Plugin._Instance.config(name, _matName1, "BlackMetal:30:15", new ConfigDescription(_matDesc));
        _spearMat2 = Plugin._Instance.config(name, _matName2, "FineWood:10:0", new ConfigDescription(_matDesc));
        _spearMat3 = Plugin._Instance.config(name, _matName3, "LinenThread:5:5", new ConfigDescription(_matDesc));
        _spearMat4 = Plugin._Instance.config(name, _matName4, "Iron:10:5", new ConfigDescription(_matDesc));
    }
    
    private static void Broadsword()
    {
        var name = Helper.Localize("$bwa_broadsword");
        _broadswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _broadswordSlashDamage = Plugin._Instance.config(name, "Slash Damage", 75f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 120f)));
        _broadswordSpiritDamage =
            Plugin._Instance.config(name, "Spirit Damage", 40f, new ConfigDescription("Base spirit damage."));
        _broadswordEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _broadswordMat1 = Plugin._Instance.config(name, _matName1, "BlackMetal:10:0", new ConfigDescription(_matDesc));
        _broadswordMat2 = Plugin._Instance.config(name, _matName2, "Silver:60:30", new ConfigDescription(_matDesc));
        _broadswordMat3 = Plugin._Instance.config(name, _matName3, "Iron:30:15", new ConfigDescription(_matDesc));
        _broadswordMat4 = Plugin._Instance.config(name, _matName4, "YggdrasilWood:10:5", new ConfigDescription(_matDesc));
    }
    
    private static void Claymore()
    {
        var name = Helper.Localize("$bwa_claymore");
        _claymoreAttackForce = Plugin._Instance.config(name, "Attack Force", 45f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _claymoreSlashDamage = Plugin._Instance.config(name, "Slash Damage", 90f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 120f)));
        _claymoreEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _claymoreMat1 = Plugin._Instance.config(name, _matName1, "Silver:40:20", new ConfigDescription(_matDesc));
        _claymoreMat2 = Plugin._Instance.config(name, _matName2, "Iron:20:10", new ConfigDescription(_matDesc));
        _claymoreMat3 = Plugin._Instance.config(name, _matName3, "FineWood:15:8", new ConfigDescription(_matDesc));
        _claymoreMat4 = Plugin._Instance.config(name, _matName4, "Bronze:10:0", new ConfigDescription(_matDesc));
    }
    
    private static void GiantAxe()
    {
        var name = Helper.Localize("$bwa_giantaxe");
        _giantAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 80f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _giantAxeChopDamage = Plugin._Instance.config(name, "Chop Damage", 60f,
            new ConfigDescription("Base chop damage.", new AcceptableValueRange<float>(1f, 100f),
                new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
        _giantAxeSlashDamage = Plugin._Instance.config(name, "Slash Damage", 120f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 150f)));
        _giantAxeEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _giantAxeMat1 = Plugin._Instance.config(name, _matName1, "BlackMetal:60:30", new ConfigDescription(_matDesc));
        _giantAxeMat2 = Plugin._Instance.config(name, _matName2, "FineWood:20:0", new ConfigDescription(_matDesc));
        _giantAxeMat3 = Plugin._Instance.config(name, _matName3, "LinenThread:5:5", new ConfigDescription(_matDesc));
        _giantAxeMat4 = Plugin._Instance.config(name, _matName4, "Iron:20:10", new ConfigDescription(_matDesc));
    }
    
    private static void GiantMace()
    {
        var name = Helper.Localize("$bwa_giantmace");
        _giantMaceAttackForce = Plugin._Instance.config(name, "Attack Force", 90f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 150f)));
        _giantMaceBluntDamage = Plugin._Instance.config(name, "Blunt Damage", 40f,
            new ConfigDescription("Base blunt damage.", new AcceptableValueRange<float>(1f, 50f)));
        _giantMaceSlashDamage = Plugin._Instance.config(name, "Slash Damage", 16f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 30f)));
        _giantMaceEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _giantMaceMat1 = Plugin._Instance.config(name, _matName1, "Bronze:30:15", new ConfigDescription(_matDesc));
        _giantMaceMat2 = Plugin._Instance.config(name, _matName2, "RoundLog:10:0", new ConfigDescription(_matDesc));
        _giantMaceMat3 = Plugin._Instance.config(name, _matName3, "Copper:5:3", new ConfigDescription(_matDesc));
        _giantMaceMat4 = Plugin._Instance.config(name, _matName4, "Tin:5:2", new ConfigDescription(_matDesc));
    }
    
    private static void Gretsword()
    {
        var name = Helper.Localize("$bwa_greatsword");
        _greatswordAttackForce = Plugin._Instance.config(name, "Attack Force", 40f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _greatswordSlashDamage = Plugin._Instance.config(name, "Slash Damage", 65f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 100f),
                new ConfigurationManagerAttributes
                {
                    ShowRangeAsPercent = false
                }));
        _greatswordEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _greatswordMat1 = Plugin._Instance.config(name, _matName1, "Iron:50:25", new ConfigDescription(_matDesc));
        _greatswordMat2 = Plugin._Instance.config(name, _matName2, "ElderBark:10:0", new ConfigDescription(_matDesc));
        _greatswordMat3 = Plugin._Instance.config(name, _matName3, "Tin:15:8", new ConfigDescription(_matDesc));
        _greatswordMat4 = Plugin._Instance.config(name, _matName4, "Chitin:10:5", new ConfigDescription(_matDesc));
    }
    
    private static void SilverAxe()
    {
        var name = Helper.Localize("$bwa_silveraxe");
        _silverAxeAttackForce = Plugin._Instance.config(name, "Attack Force", 55f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _silverAxeChopDamage = Plugin._Instance.config(name, "Chop Damage", 55f,
            new ConfigDescription("Base chop damage.", new AcceptableValueRange<float>(1f, 150f)));
        _silverAxeSlashDamage = Plugin._Instance.config(name, "Slash Damage", 80f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 120f)));
        _silverAxeEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _silverAxeMat1 = Plugin._Instance.config(name, _matName1, "Silver:60:30", new ConfigDescription(_matDesc));
        _silverAxeMat2 = Plugin._Instance.config(name, _matName2, "WolfClaw:10:5", new ConfigDescription(_matDesc));
        _silverAxeMat3 = Plugin._Instance.config(name, _matName3, "FineWood:15:0", new ConfigDescription(_matDesc));
        _silverAxeMat4 = Plugin._Instance.config(name, _matName4, "Iron:10:5", new ConfigDescription(_matDesc));
    }
    
    private static void Tulwar()
    {
        var name = Helper.Localize("$bwa_tulwar");
        _tulwarAttackForce = Plugin._Instance.config(name, "Attack Force", 50f, new ConfigDescription(
            "Base attack force.", new AcceptableValueRange<float>(1f, 100f), new ConfigurationManagerAttributes
            {
                ShowRangeAsPercent = false
            }));
        _tulwarSlashDamage = Plugin._Instance.config(name, "Slash Damage", 120f,
            new ConfigDescription("Base slash damage.", new AcceptableValueRange<float>(1f, 200f)));
        _tulwarEnable = Plugin._Instance.config(name, "Recipe", value: true, new ConfigDescription(_enableDesc));
        _tulwarMat1 = Plugin._Instance.config(name, _matName1, "BlackMetal:70:35", new ConfigDescription(_matDesc));
        _tulwarMat2 = Plugin._Instance.config(name, _matName2, "FineWood:20:0", new ConfigDescription(_matDesc));
        _tulwarMat3 = Plugin._Instance.config(name, _matName3, "LinenThread:10:5", new ConfigDescription(_matDesc));
        _tulwarMat4 = Plugin._Instance.config(name, _matName4, "Iron:30:15", new ConfigDescription(_matDesc));
    }
}