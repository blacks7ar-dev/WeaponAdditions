using UnityEngine;

namespace WeaponAdditions.Utils;

public static class Helper
{
    // public static string Localize(string name)
    // {
    //     return Localization.instance.Localize(name).Trim();
    // }
    
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