using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour {

  public vp_FPPlayerEventHandler playerEventHandler;
  public GameUI gameUI;
  public Camera camera;

  private bool isZooming = false;
  private bool hasZoomed = false;
	
	void Update () {
	  if(playerEventHandler.Zoom.Active && !isZooming) {
      isZooming = true;
      StartCoroutine("ZoomSniper");
    } else if (!playerEventHandler.Zoom.Active) {
      gameUI.HideSniperZoom();
      isZooming = false;
      hasZoomed = false;
    }

    if (hasZoomed) {
      camera.fieldOfView = 6;
    }
	}

  IEnumerator ZoomSniper(){
    yield return new WaitForSeconds(0.15f);
    gameUI.ShowSniperZoom();
    hasZoomed = true;
  }
}
