using UnityEngine;
using WeaponAdditions.Utils;

namespace WeaponAdditions.Functions;

public static class RegisterPrefabsToZNetScene
{
    private static ZNetScene _zNetScene => ZNetScene.instance;

    public static void Init()
    {
        if (!Helper.ZNetSceneAwake()) return;
        _zNetScene.AddClonedObject(PrefabsSetup._silverAxe);
        _zNetScene.AddClonedObject(PrefabsSetup._blackMetalSpear);
        _zNetScene.AddClonedObject(PrefabsSetup._broadsword);
        _zNetScene.AddClonedObject(PrefabsSetup._claymore);
        _zNetScene.AddClonedObject(PrefabsSetup._giantAxe);
        _zNetScene.AddClonedObject(PrefabsSetup._giantMace);
        _zNetScene.AddClonedObject(PrefabsSetup._greatsword);
        _zNetScene.AddClonedObject(PrefabsSetup._tulwar);
        _zNetScene.AddClonedObject(PrefabsSetup._battleHammer);
        _zNetScene.AddClonedObject(PrefabsSetup._bronzeBattleAxe);
        _zNetScene.AddClonedObject(PrefabsSetup._bronzeHammer);
        _zNetScene.AddClonedObject(PrefabsSetup._bronzeMace);
        _zNetScene.AddClonedObject(PrefabsSetup._dagger);
        _zNetScene.AddClonedObject(PrefabsSetup._darkSword);
        _zNetScene.AddClonedObject(PrefabsSetup._draconicDagger);
        _zNetScene.AddClonedObject(PrefabsSetup._draconicGreatsword);
        _zNetScene.AddClonedObject(PrefabsSetup._draconicScythe);
        _zNetScene.AddClonedObject(PrefabsSetup._draconicSword);
        _zNetScene.AddClonedObject(PrefabsSetup._dragonBlade);
        _zNetScene.AddClonedObject(PrefabsSetup._elvenAxe);
        _zNetScene.AddClonedObject(PrefabsSetup._elvenHammer);
        _zNetScene.AddClonedObject(PrefabsSetup._elvenShield);
        _zNetScene.AddClonedObject(PrefabsSetup._elvenSpear);
        _zNetScene.AddClonedObject(PrefabsSetup._elvenSword);
        _zNetScene.AddClonedObject(PrefabsSetup._flameMetalGreatsword);
        _zNetScene.AddClonedObject(PrefabsSetup._flameMetalHammer);
        _zNetScene.AddClonedObject(PrefabsSetup._flameMetalSword);
        _zNetScene.AddClonedObject(PrefabsSetup._ironSpikedMace);
        _zNetScene.AddClonedObject(PrefabsSetup._poisonousSpikedMace);
    }

    public static void Effects()
    {
        if (!Helper.ZNetSceneAwake()) return;
        var fx1 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_block_camshake");
        _zNetScene.AddClonedObject(fx1);
        var fx6 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_himminafl_aoe");
        _zNetScene.AddClonedObject(fx6);
        var fx7 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_himminafl_hit");
        _zNetScene.AddClonedObject(fx7);
        var fx2 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_hit_camshake");
        _zNetScene.AddClonedObject(fx2);
        var fx4 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_hit_camshake_knife");
        _zNetScene.AddClonedObject(fx4);
        var fx5 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_sledge_demolisher_hit");
        _zNetScene.AddClonedObject(fx5);
        var fx9 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_sledge_demolisher_hit1");
        _zNetScene.AddClonedObject(fx9);
        var fx8 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_StaffShield_Hit");
        _zNetScene.AddClonedObject(fx8);
        Helper.ShaderSwap(fx8);
        var fx3 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_swing_camshake");
        _zNetScene.AddClonedObject(fx3);
        var sfx12 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_arrow_hit");
        _zNetScene.AddClonedObject(sfx12);
        var sfx1 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_atgeir_attack");
        _zNetScene.AddClonedObject(sfx1);
        var sfx2 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_axe_hit");
        _zNetScene.AddClonedObject(sfx2);
        var sfx3 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_axe_swing");
        _zNetScene.AddClonedObject(sfx3);
        var sfx4 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_battleaxe_hit");
        _zNetScene.AddClonedObject(sfx4);
        var sfx5 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_battleaxe_swing_wosh");
        _zNetScene.AddClonedObject(sfx5);
        var sfx17 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_club_hit");
        _zNetScene.AddClonedObject(sfx17);
        var sfx18 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_club_swing");
        _zNetScene.AddClonedObject(sfx18);
        var sfx13 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_knife_swing");
        _zNetScene.AddClonedObject(sfx13);
        var sfx6 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_kromsword_swing");
        _zNetScene.AddClonedObject(sfx6);
        var sfx7 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_metal_blocked");
        _zNetScene.AddClonedObject(sfx7);
        var sfx14 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_sledge_swing");
        _zNetScene.AddClonedObject(sfx14);
        var sfx8 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_spear_hit");
        _zNetScene.AddClonedObject(sfx8);
        var sfx9 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_sword_hit");
        _zNetScene.AddClonedObject(sfx9);
        var sfx15 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_spear_throw");
        _zNetScene.AddClonedObject(sfx15);
        var sfx10 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_sword_swing");
        _zNetScene.AddClonedObject(sfx10);
        var sfx11 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_wood_blocked");
        _zNetScene.AddClonedObject(sfx11);
        var vfx1 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_vfx_arrowhit");
        _zNetScene.AddClonedObject(vfx1);
        var vfx2 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_vfx_blocked");
        _zNetScene.AddClonedObject(vfx2);
        var vfx3 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_vfx_clubhit");
        _zNetScene.AddClonedObject(vfx3);
        var vfx4 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_vfx_HitSparks");
        _zNetScene.AddClonedObject(vfx4);
        var vfx5 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_vfx_sledge_hit");
        _zNetScene.AddClonedObject(vfx5);
        var daggerProj = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_dagger_projectile");
        _zNetScene.AddClonedObject(daggerProj);
        var shurikenProj = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_shuriken_projectile1");
        _zNetScene.AddClonedObject(shurikenProj);
    }
}