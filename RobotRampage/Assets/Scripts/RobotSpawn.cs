using UnityEngine;
using System.Collections;

public class RobotSpawn : MonoBehaviour {

  public string robotToSpawn;

  void Start () {
    StartCoroutine("SpawnRobot");
	}
	
  IEnumerator SpawnRobot() {
    while (true) {
      yield return new WaitForSeconds(10);
      GameObject robot = Instantiate(Resources.Load<GameObject>(robotToSpawn));
      robot.transform.position = transform.position;
    }
  }
}
