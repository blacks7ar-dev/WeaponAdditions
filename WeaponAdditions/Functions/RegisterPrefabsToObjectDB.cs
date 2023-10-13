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
        StatsSetup.BlackMetalSpear(PrefabsSetup._blackMetalSpear.GetComponent<ItemDrop>());
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
        _objectDB.AddClonedObject(PrefabsSetup._battleHammer);
        _objectDB.AddClonedObject(PrefabsSetup._bronzeBattleAxe);
        _objectDB.AddClonedObject(PrefabsSetup._bronzeHammer);
        _objectDB.AddClonedObject(PrefabsSetup._bronzeMace);
        _objectDB.AddClonedObject(PrefabsSetup._dagger);
        _objectDB.AddClonedObject(PrefabsSetup._darkSword);
        _objectDB.AddClonedObject(PrefabsSetup._draconicDagger);
        _objectDB.AddClonedObject(PrefabsSetup._draconicGreatsword);
        _objectDB.AddClonedObject(PrefabsSetup._draconicScythe);
        _objectDB.AddClonedObject(PrefabsSetup._draconicSword);
        _objectDB.AddClonedObject(PrefabsSetup._dragonBlade);
        _objectDB.AddClonedObject(PrefabsSetup._elvenAxe);
        _objectDB.AddClonedObject(PrefabsSetup._elvenHammer);
        _objectDB.AddClonedObject(PrefabsSetup._elvenShield);
        _objectDB.AddClonedObject(PrefabsSetup._elvenSpear);
        _objectDB.AddClonedObject(PrefabsSetup._elvenSword);
        _objectDB.AddClonedObject(PrefabsSetup._flameMetalGreatsword);
        _objectDB.AddClonedObject(PrefabsSetup._flameMetalHammer);
        _objectDB.AddClonedObject(PrefabsSetup._flameMetalSword);
        _objectDB.AddClonedObject(PrefabsSetup._ironSpikedMace);
        _objectDB.AddClonedObject(PrefabsSetup._poisonousSpikedMace);
    }
}