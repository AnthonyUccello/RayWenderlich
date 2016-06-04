using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

  public int health;

  public void TakeDamage(int amount) {

    health -= amount;

    if (health <= 0)
    {
      Destroy(gameObject);
    }
  }
}
