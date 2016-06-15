using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Constants {

  // Scenes
  public const string SceneBattle = "Battle";
  public const string SceneMenu = "Menu";

  // Gun Types
  public const string PistolTag = "Pistol";
  public const string ShotgunTag = "Shotgun";
  public const string AssaultRifleTag = "AssaultRifle";

  // Pickup Types
  public const int PickUpPistolAmmo = 1;
  public const int PickUpAssaultRifleAmmo = 2;
  public const int PickUpShotgunAmmo = 3;
  public const int PickUpHealth = 4;
  public const int PickUpArmor = 5;

  // Misc
  public const string Game = "Game";
  public const float CameraDefaultZoom = 60f;

  public static readonly int[] AllPickupTypes = new int[5] {
    PickUpPistolAmmo,
    PickUpAssaultRifleAmmo,
    PickUpShotgunAmmo,
    PickUpHealth,
    PickUpArmor
  };
}
