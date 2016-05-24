using UnityEngine;
using System.Collections;

public class TrapDoor : MonoBehaviour
{
  private float speed = 2.2f;
  private bool moving = true;
  private float restingYTop = 6.83f;
  private float restingYBot = 1.12f;

	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update (){
    if (moving == true){
      transform.Translate(Vector3.down * Time.deltaTime * speed);

      if (transform.position.y < restingYBot){
        moving = false;
      }
    }
	}

  public void beginClose(){
    moving = true;
  }

  public void resetDoor(){
    transform.position = new Vector3(transform.position.x, restingYTop, transform.position.z);
    moving = true;
  }
}
