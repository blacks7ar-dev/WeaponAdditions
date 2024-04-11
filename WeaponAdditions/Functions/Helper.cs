using BepInEx.Bootstrap;

namespace WeaponAdditions.Functions;

public static class Helper
{
    public static bool CheckBowPlugin()
    {
        if (!Chainloader.PluginInfos.ContainsKey("blacks7ar.BowPlugin")) return false;
        Logging.LogInfo("BowPlugin detected.. ElvenBow and SeekerBows recipe will now be disabled from WeaponAdditions.");
        return true;
    }
}