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
  [SerializeField]
  private Text pickupText;

  [SerializeField]
  Player player;

  // Use this for initialization
  void Start () {
    SetArmorText(player.armor);
    SetHealthText(player.health);
	}

  public void SetArmorText(int armor) {
    armorText.text = "Armor: " + armor;
  }

  public void SetHealthText(int health) {
    healthText.text = "Health: " + health;
  }

  public void SetAmmoText(int ammo) {
    ammoText.text = "Ammo: " + ammo;
  }

  public void SetScoreText(int score ) {
    scoreText.text = "Score: " + score;
  }

  public void SetPickUpText(string text) {
    pickupText.GetComponent<Text>().enabled = true;
    pickupText.text = text;
    StartCoroutine("hidePickupText");
  }

  IEnumerator hidePickupText() {
    yield return new WaitForSeconds(4);
    pickupText.GetComponent<Text>().enabled = false;
  }
}
