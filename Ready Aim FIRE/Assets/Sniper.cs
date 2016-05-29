using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour {

  public vp_FPPlayerEventHandler playerEventHandler;
  public GameUI gameUI;
  public Camera mainCamera;
  private bool isZooming = false;
  private bool hasZoomed = false;
	
	void Update () {
	  if(playerEventHandler.Zoom.Active && !isZooming) {
      isZooming = true;
      StartCoroutine("zoomSniper");
    } else if (!playerEventHandler.Zoom.Active) {
      gameUI.HideSniperZoom();
      isZooming = false;
      hasZoomed = false;
    }

    if (hasZoomed) {
      mainCamera.fieldOfView = 6;
    }
	}

  IEnumerator zoomSniper(){
    yield return new WaitForSeconds(0.15f);
    gameUI.ShowSniperZoom();
    hasZoomed = true;
  }
}
