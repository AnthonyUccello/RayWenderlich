using UnityEngine;
using System.Collections;

public class AssaultRifle : Gun {

	// Update is called once per frame
	void Update () {
    // Automatic Fire
    if (Input.GetMouseButton(0) && Time.time - lastFireTime > fireRate) {
      lastFireTime = Time.time;
 
      // Check if ammo
      if (ammo.HasAmmo(tag)) {
        Fire();
        ammo.ConsumeAmmo(tag);
      } else {
          // Play dry fire
          GetComponent<AudioSource>().PlayOneShot(dryFire);
      }
    }

    // Right Click (Zoom)
    if (Input.GetMouseButton(1)) {
      Camera.main.fieldOfView = Constants.CameraDefaultZoom / zoomFactor;
    } else {
      Camera.main.fieldOfView = Constants.CameraDefaultZoom;
    }
  }
}
