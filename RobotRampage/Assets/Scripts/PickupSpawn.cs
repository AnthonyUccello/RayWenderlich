using UnityEngine;
using System.Collections;

public class PickupSpawn : MonoBehaviour {

  private GameObject pickup;

  // Use this for initialization
  void Start () {
    spawnPickup();
	}

  public void PickupWasPickedUp() {
    StartCoroutine("respawnAmmo");
  }
	
  IEnumerator respawnAmmo() {
    yield return new WaitForSeconds(20);
    spawnPickup();
  }

  void spawnPickup() {
    pickup = Instantiate(Resources.Load("Pickup") as GameObject);
    pickup.transform.position = transform.position;
    pickup.transform.parent = transform;
    pickup.GetComponent<Pickup>().type = 
      Constants.AllPickupTypes[Random.Range(0, Constants.AllPickupTypes.Length - 1)];
  }

}
