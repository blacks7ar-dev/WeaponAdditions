namespace WeaponAdditions.Functions;

public static class Logging
{
    public static void LogDebug(string debug)
    {
        Plugin.WALogger.LogDebug(debug);
    }

    public static void LogInfo(string info)
    {
        Plugin.WALogger.LogInfo(info);
    }

    public static void LogWarning(string warning)
    {
        Plugin.WALogger.LogWarning(warning);
    }

    public static void LogError(string error)
    {
        Plugin.WALogger.LogError(error);
    }
}