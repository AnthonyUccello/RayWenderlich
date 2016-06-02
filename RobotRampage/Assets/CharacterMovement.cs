using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
  public float speed = 2;
  public float turnSpeed = 100;

  void Update()
  {
    if (Input.GetKey("w"))
    {
      transform.Translate(Vector3.forward * speed * Time.deltaTime);
    } else if (Input.GetKey("a"))
    {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
    } else if (Input.GetKey("s"))
    {
      transform.Translate(Vector3.right * speed * Time.deltaTime);
    } else if (Input.GetKey("d"))
    {
      transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
  }

}
