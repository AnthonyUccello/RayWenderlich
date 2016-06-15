using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class StartingMenu : MonoBehaviour {

	public void StartGame() {
    EditorSceneManager.LoadScene("Battle");
  }

  public void Quit() {
    Application.Quit();
  }
}
