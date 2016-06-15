using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class Gun : MonoBehaviour {
  
  public Ammo ammo;
  public float fireRate;
  public float zoomFactor;
  public int range;
  public int damage;
  public AudioClip dryFire;

  protected float lastFireTime;

  void Start() {
    lastFireTime = Time.time - 10;
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
    if (hitObject.GetComponent<Player>() != null) {
      hitObject.GetComponent<Player>().TakeDamage(damage);
    }

    if (hitObject.GetComponent<Robot>() != null) {
      hitObject.GetComponent<Robot>().TakeDamage(damage);
    }
  }
}
