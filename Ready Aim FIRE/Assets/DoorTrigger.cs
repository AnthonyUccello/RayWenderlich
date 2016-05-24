using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

  public TrapDoor trapDoor;

  void OnTriggerEnter(Collider other){
    trapDoor.resetDoor();
  }
}
