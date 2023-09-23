using System.Linq;
using System.Reflection;
using UnityEngine;

namespace WeaponAdditions.Functions;

public static class PrefabsSetup
{
    public static AssetBundle _weaponBundle;
    public static GameObject _silverAxe;
    public static GameObject _blackMetalSpear;
    public static GameObject _broadsword;
    public static GameObject _claymore;
    public static GameObject _giantAxe;
    public static GameObject _giantMace;
    public static GameObject _greatsword;
    public static GameObject _tulwar;

    public static void Init()
    {
        _weaponBundle = GetAssetBundleFromResources("weaponbundle");
        _blackMetalSpear = _weaponBundle.LoadAsset<GameObject>("BWA_BlackMetalSpear");
        _broadsword = _weaponBundle.LoadAsset<GameObject>("BWA_Broadsword");
        _claymore = _weaponBundle.LoadAsset<GameObject>("BWA_Claymore");
        _giantAxe = _weaponBundle.LoadAsset<GameObject>("BWA_GiantAxe");
        _giantMace = _weaponBundle.LoadAsset<GameObject>("BWA_GiantMace");
        _greatsword = _weaponBundle.LoadAsset<GameObject>("BWA_Greatsword");
        _silverAxe = _weaponBundle.LoadAsset<GameObject>("BWA_SilverAxe");
        _tulwar = _weaponBundle.LoadAsset<GameObject>("BWA_Tulwar");
    }
    
    private static AssetBundle GetAssetBundleFromResources(string filename)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var name = assembly.GetManifestResourceNames().Single(x => x.EndsWith(filename));
        using var stream = assembly.GetManifestResourceStream(name);
        return AssetBundle.LoadFromStream(stream);
    }
}