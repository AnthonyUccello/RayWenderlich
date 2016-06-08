using UnityEngine;
using System.Collections;

public class Player : Unit
{
  public int armor;

  public GameUI ui;

  new public void TakeDamage(int amount) {

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

      // Turn negative armor into remaining health damage
      healthDamage = effectiveArmor;
      armor = 0;
    }

    base.TakeDamage(amount);
    ui.SetHealthText(health);
    ui.SetArmorText(armor);
  }
}