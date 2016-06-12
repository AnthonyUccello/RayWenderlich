using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

  public GameObject gameOverPanel;

  public void ShowGameOver() {
    gameOverPanel.SetActive(true);
  }

  public void RestartGame() {
    SceneManager.LoadScene(Constants.SceneBattle);
    gameOverPanel.SetActive(true);
  }

  public void Exit() {
    Application.Quit();
  }
}
