using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ammo : MonoBehaviour {

  [SerializeField]
  GameUI gameUI;

  private int pistolAmmo = 20;
  private int shotgunAmmo = 10;
  private int assaultRifleAmmo = 50;

  public Dictionary<string, int> tagToAmmo;

  void Awake() {
    tagToAmmo = new Dictionary<string, int> {
      { Constants.PistolTag , pistolAmmo},
      { Constants.ShotgunTag , shotgunAmmo},
      { Constants.AssaultRifleTag , assaultRifleAmmo},
    };
  }

  public void AddAmmo(string tag, int ammo) {
    if (!tagToAmmo.ContainsKey(tag)) {
      Debug.LogError("Unrecognized gun type passed: " + tag);
    }

    tagToAmmo[tag] += ammo;
  }

  // Returns true if gun has ammo
  public bool HasAmmo(string tag) {
    if (!tagToAmmo.ContainsKey(tag)) {
      Debug.LogError("Unrecognized gun type passed: " + tag);
    }

    return tagToAmmo[tag] > 0;
  }

  public void ConsumeAmmo(string tag) {
    if (!tagToAmmo.ContainsKey(tag)) {
      Debug.LogError("Unrecognized gun type passed:" + tag);
    }

    tagToAmmo[tag]--;

    gameUI.SetAmmoText(tagToAmmo[tag]);
  }

  public int GetAmmo(string tag) {
    if (!tagToAmmo.ContainsKey(tag))
    {
      Debug.LogError("Unrecognized gun type passed:" + tag);
    }

    return tagToAmmo[tag];
  }

}
