using BepInEx.Logging;

namespace WeaponAdditions.Functions;

public static class Logging
{
    private static readonly ManualLogSource WALogger = Logger.CreateLogSource(Plugin.modName);
    
    public static void LogDebug(string debug)
    {
        WALogger.LogDebug(debug);
    }

    public static void LogInfo(string info)
    {
        WALogger.LogInfo(info);
    }

    public static void LogWarning(string warning)
    {
        WALogger.LogWarning(warning);
    }

    public static void LogError(string error)
    {
        WALogger.LogError(error);
    }
}