using UnityEngine;

namespace WeaponAdditions.Utils;

public static class Helper
{
    public static string Localize(string name)
    {
        return Localization.instance.Localize(name).Trim();
    }
    
    public static void AddClonedObject(this ZNetScene zNetScene, GameObject gameObject, bool overWrite = true)
    {
        GameObject prefab;
        if ((prefab = zNetScene.GetPrefab(gameObject.name)) != null)
        {
            if (!overWrite) return;
            zNetScene.m_prefabs.Remove(prefab);
            zNetScene.m_namedPrefabs.Remove(gameObject.name.GetStableHashCode());
        }

        zNetScene.m_prefabs.Add(gameObject);
        zNetScene.m_namedPrefabs.Add(gameObject.name.GetStableHashCode(), gameObject);
    }
    
    public static void AddClonedObject(this ObjectDB objectDB, GameObject gameObject, bool overWrite = true)
    {
        GameObject prefab;
        if ((prefab = objectDB.GetItemPrefab(gameObject.name)) != null)
        {
            if (!overWrite) return;
            objectDB.m_items.Remove(prefab);
            objectDB.m_itemByHash.Remove(gameObject.name.GetStableHashCode());
        }

        objectDB.m_items.Add(gameObject);
        objectDB.m_itemByHash.Add(gameObject.name.GetStableHashCode(), gameObject);
    }
    
    public static void AddRecipe(this ObjectDB objectDB, Recipe recipe, bool overWrite = true)
    {
        if (objectDB.m_recipes.Contains(recipe))
        {
            if (!overWrite) return;
            objectDB.m_recipes.Remove(recipe);
        }
        objectDB.m_recipes.Add(recipe);
    }

    public static bool ObjectDBAwake()
    {
        return ObjectDB.instance != null && ObjectDB.instance.m_items.Count != 0 &&
               ObjectDB.instance.GetItemPrefab("Wood") != null;
    }

    public static bool ZNetSceneAwake()
    {
        return ZNetScene.instance != null && ZNetScene.instance.m_prefabs.Count != 0 &&
               ZNetScene.instance.GetPrefab("piece_workbench") != null;
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
                if (material.shader.name == "Custom/Creature")
                {
                    material.shader = Shader.Find("Custom/Creature");
                }
            }
        }
    }
}