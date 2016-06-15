using UnityEngine;
using System.Collections;

public class RobotSpawn : MonoBehaviour {

  public string robotToSpawn;

  private int healthBonus = 0;

  void Start () {
    StartCoroutine("SpawnRobot");
	}
	
  IEnumerator SpawnRobot() {
    while (true) {
      yield return new WaitForSeconds(10);
      healthBonus += 2;
      GameObject robot = Instantiate(Resources.Load<GameObject>(robotToSpawn));
      robot.transform.position = transform.position;
      robot.GetComponent<Robot>().health += healthBonus;
    }
  }
}
