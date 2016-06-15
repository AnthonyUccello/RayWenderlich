using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
  public int health;
  public int armor;
  public Ammo ammo;

  public GameUI ui;
  public GunEquipper gunEquipper;
  public Game game;

  public void TakeDamage(int amount) {
    int healthDamage = amount;

    if (armor > 0) {
      int effectiveArmor = armor * 2;
      effectiveArmor -= healthDamage;

      // If there is still armor, don't need to process health damage
      if (effectiveArmor > 0) {
        armor = effectiveArmor / 2;
        ui.SetArmorText(armor);
        return;
      }
      
      armor = 0;
      ui.SetArmorText(armor);
    }

    health -= healthDamage;

    ui.SetHealthText(health);
    ui.SetArmorText(armor);

    if (health <= 0) {
      game.GameOver();
    }
  }

  // Player has picked up item, apply its effects
  public void PickUpItem(int pickupType)
  {
    switch (pickupType) {
      case Constants.PickUpArmor:
        pickupArmor();
        break;
      case Constants.PickUpHealth:
        pickupHealth();
        break;
      case Constants.PickUpAssaultRifleAmmo:
        pickupAssaultRifleAmmo();
        break;
      case Constants.PickUpPistolAmmo:
        pickupPisolAmmo();
        break;
      case Constants.PickUpShotgunAmmo:
        pickupShotgunAmmo();
        break;
      default:
        Debug.LogError("Bad pickup type passed" + pickupType);
        break;
    }
  }

  private void pickupHealth() {
    health += 30;
    ui.SetPickUpText("Health picked up + 30 Health");
  }

  private void pickupArmor() {
    armor += 15;
    ui.SetPickUpText("Armor picked up + 15 armor");
  }

  private void pickupAssaultRifleAmmo() {
    ammo.AddAmmo(Constants.AssaultRifleTag, 50);
    ui.SetPickUpText("Assault rifle ammo picked up + 50 ammo");
    ui.SetAmmoText(ammo.GetAmmo(Constants.AssaultRifleTag));
  }

  private void pickupPisolAmmo() {
    ammo.AddAmmo(Constants.PistolTag, 20);
    ui.SetPickUpText("Pistol ammo picked up + 20 ammo");
    ui.SetAmmoText(ammo.GetAmmo(Constants.PistolTag));
  }

  private void pickupShotgunAmmo() {
    ammo.AddAmmo(Constants.ShotgunTag, 10);
    ui.SetPickUpText("Shotgun ammo picked up + 10 ammo");
    ui.SetAmmoText(ammo.GetAmmo(Constants.ShotgunTag));
  }
}