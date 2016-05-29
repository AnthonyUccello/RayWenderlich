using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

  public Text ammoText;
  public GameObject sniperZoom;
  public vp_PlayerEventHandler playerEventHandler;
	
	// Update is called once per frame
	void Update () {
    ammoText.text = "Ammo:" + playerEventHandler.CurrentWeaponAmmoCount.Get();
  }

  public void ShowSniperZoom(){
    sniperZoom.GetComponent<Image>().enabled = true;
  }

  public void HideSniperZoom(){
    sniperZoom.GetComponent<Image>().enabled = false;
  }
}
