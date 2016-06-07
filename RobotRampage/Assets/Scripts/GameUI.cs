using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

  [SerializeField]
  private Text ammoText;
  [SerializeField]
  private Text healthText;
  [SerializeField]
  private Text armorText;
  [SerializeField]
  private Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void SetArmorText(int armor) {

  }

  public void SetHealthText(int health) {
    healthText.text = "Health: " + health;
  }

  public void SetAmmoText(int ammo) {

  }

  public void SetScoreText(int score ) {

  }
}
