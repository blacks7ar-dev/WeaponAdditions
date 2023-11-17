using BepInEx.Bootstrap;
using UnityEngine;

namespace WeaponAdditions.Utils;

public static class Helper
{
    public static bool CheckBowPlugin()
    {
        if (!Chainloader.PluginInfos.ContainsKey("blacks7ar.BowPlugin")) return false;
        Logging.LogInfo("BowPlugin detected.. ElvenBow and SeekerBows recipe will now be disabled from WeaponAdditions.");
        return true;
    }
    
    public static void ShaderSwap(GameObject gameObject)
    {
        var renderers = gameObject.GetComponentsInChildren<Renderer>(true);
        foreach (var renderer in renderers)
        {
            if (renderer == null) continue;
            foreach (var material in renderer.sharedMaterials)
            {
                if (material == null) continue;
                if (material.shader.name == "Custom/Distortion")
                {
                    material.shader = Shader.Find("Custom/Distortion");
                }
            }
        }
    }
}