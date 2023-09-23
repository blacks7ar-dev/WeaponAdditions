using WeaponAdditions.Utils;

namespace WeaponAdditions.Functions;

public static class RegisterPrefabsToObjectDB
{
    private static ObjectDB _objectDB => ObjectDB.instance;

    public static void Init()
    {
        if (!Helper.ObjectDBAwake()) return;
        _objectDB.AddClonedObject(PrefabsSetup._silverAxe);
        StatsSetup.SilverAxe(PrefabsSetup._silverAxe.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._blackMetalSpear);
        StatsSetup.Spear(PrefabsSetup._blackMetalSpear.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._broadsword);
        StatsSetup.Broadsword(PrefabsSetup._broadsword.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._claymore);
        StatsSetup.Claymore(PrefabsSetup._claymore.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._giantAxe);
        StatsSetup.GiantAxe(PrefabsSetup._giantAxe.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._giantMace);
        StatsSetup.GiantMace(PrefabsSetup._giantMace.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._greatsword);
        StatsSetup.Greatsword(PrefabsSetup._greatsword.GetComponent<ItemDrop>());
        _objectDB.AddClonedObject(PrefabsSetup._tulwar);
        StatsSetup.Tulwar(PrefabsSetup._tulwar.GetComponent<ItemDrop>());
    }
}