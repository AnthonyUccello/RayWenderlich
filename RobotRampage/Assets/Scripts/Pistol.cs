using UnityEngine;
using System.Collections;

public class Pistol : Gun {

  void Update () {
    // Shotgun & Pistol have semi-auto fire rate
    if (Input.GetMouseButtonDown(0) && (Time.time - lastFireTime) > fireRate) {
      lastFireTime = Time.time;

      // Left Click
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
