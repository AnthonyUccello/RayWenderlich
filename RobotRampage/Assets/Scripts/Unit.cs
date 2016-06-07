using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

  public GameUI ui;

  public int health;
  public int armor;
  public int pistolAmmo;
  public int shotgunAmmo;
  public int assaultRifleAmmo;

  public void TakeDamage(int amount) {

    health -= amount;

    if (health <= 0)
    {
      Destroy(gameObject);
    }

    ui.SetHealthText(health);
  }
}
