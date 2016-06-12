using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

  public GameObject ammoGameObject;
  public int type;

  void OnTriggerEnter(Collider collider) {
    if (collider.gameObject.tag == "Player") {
      collider.gameObject.GetComponent<Player>().PickUpItem(type);
      GetComponentInParent<PickupSpawn>().PickupWasPickedUp();
      Destroy(gameObject);
    }
  }
}
