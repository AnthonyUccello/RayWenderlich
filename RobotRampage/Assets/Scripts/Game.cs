using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

  public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  if (player == null)
    {
      Debug.Log("Game Over");
    }
	}
}
