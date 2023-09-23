﻿using System.Security.Cryptography;
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
    }

    public static void Effects()
    {
        if (!Helper.ZNetSceneAwake()) return;
        var fx1 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_block_camshake");
        _zNetScene.AddClonedObject(fx1);
        var fx2 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_hit_camshake");
        _zNetScene.AddClonedObject(fx2);
        var fx3 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_fx_swing_camshake");
        _zNetScene.AddClonedObject(fx3);
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
        var sfx6 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_kromsword_swing");
        _zNetScene.AddClonedObject(sfx6);
        var sfx7 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_metal_blocked");
        _zNetScene.AddClonedObject(sfx7);
        var sfx8 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_spear_hit");
        _zNetScene.AddClonedObject(sfx8);
        var sfx9 = PrefabsSetup._weaponBundle.LoadAsset<GameObject>("bwa_sfx_sword_hit");
        _zNetScene.AddClonedObject(sfx9);
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
    }
}