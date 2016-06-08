using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class Gun : MonoBehaviour {
  
  [SerializeField]
  Ammo ammo;

  public int range;
  public int damage;

	void Update () {

    if (Input.GetMouseButtonDown(0)) {
      // Left Click
      // Check if ammo
      if (ammo.HasAmmo(tag)) {
        Fire();
        ammo.ConsumeAmmo(tag);
      } else {
        // Play dry fire
      }

    } else if (Input.GetMouseButtonDown(1)) {
      // Right Click (Zoom)
    }

  }

  protected void Fire() {
    GetComponent<AudioSource>().Play();
    GetComponent<Animation>().Play();

    Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit, range)) {
      processHit(hit.collider.gameObject);
    }
  }

  private void processHit(GameObject hitObject) {
    if (hitObject.GetComponent<Unit>() == null)
    {
      return;
    }

    hitObject.GetComponent<Unit>().TakeDamage(damage);
  }
}
