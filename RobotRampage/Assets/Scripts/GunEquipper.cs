using UnityEngine;
using System.Collections;

public class GunEquipper : MonoBehaviour {

  [SerializeField]
  GameUI gameUI;
  [SerializeField]
  Ammo ammo;

  public GameObject pistol;
  public GameObject assaultRifle;
  public GameObject shotgun;
  public GameObject activeGun;

	// Use this for initialization
	void Start () {
    gameUI.SetAmmoText(ammo.GetAmmo(activeGun.tag));
	}
	
	// Update is called once per frame
	void Update () {

    if (Input.GetKeyDown("1"))
    {
      loadWeapon(pistol);
    } else if (Input.GetKeyDown("2"))
    {
      loadWeapon(assaultRifle);
    } else if (Input.GetKeyDown("3"))
    {
      loadWeapon(shotgun);
    }

  }

  private void loadWeapon(GameObject weapon) {

    pistol.SetActive(false);
    assaultRifle.SetActive(false);
    shotgun.SetActive(false);

    weapon.SetActive(true);
    activeGun = weapon;
    gameUI.SetAmmoText(ammo.GetAmmo(activeGun.tag));
  }

  public GameObject GetActiveWeapon() {
    return activeGun;
  }
}
