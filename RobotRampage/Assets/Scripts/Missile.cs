using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

  public float speed = 5f;
  public int damage = 10;

	// Use this for initialization
	void Start () {
    StartCoroutine("deathTimer");
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

  void OnCollisionEnter(Collision collider)
  {
    if (collider.gameObject.tag == "Player")
    {
      collider.gameObject.GetComponent<Unit>().TakeDamage(damage);
    }

    Destroy(gameObject);
  }

  IEnumerator deathTimer()
  {
    yield return new WaitForSeconds(10);
    Destroy(gameObject);
  }
}
