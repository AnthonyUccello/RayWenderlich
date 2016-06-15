using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {

  public int health;
  public int range;
  public float fireRate;

  public Transform target;
  public Transform missileFireSpot;
  NavMeshAgent agent;

  private float timeLastFired;

	// Use this for initialization
	void Start () {
    agent = GetComponent<NavMeshAgent>();
    target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
    agent.SetDestination(target.position);

    if (Vector3.Distance(transform.position, target.position) < range
        && Time.time - timeLastFired > fireRate)
    {
      timeLastFired = Time.time;
      fire();
    }
	}

  private void fire() {
    GameObject missile = Instantiate(Resources.Load<GameObject>("RobotMissile"));
    missile.transform.position = missileFireSpot.transform.position;
    missile.transform.rotation = missileFireSpot.transform.rotation;
  }

  public void TakeDamage(int amount) {
    health -= amount;

    if (health <= 0)
    {
      Destroy(gameObject);
    }

    // Add player score, play sound effect and die
    if (health <= 0) {
      GameObject
        .FindGameObjectWithTag(Constants.Game)
        .GetComponent<Game>().AddRobotKillToScore();
    } else {
      // Play got hit animation
      GetComponent<Animation>().Play();
    }
  }
}
