using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Game : MonoBehaviour {

  public GameObject gameOverPanel;
  public GameUI gameUI;
  public GameObject player;

  public int score = 0;

  private bool isGameOver = false;

  void Start() {
    StartCoroutine("increaseScoreEachSecond");
    isGameOver = false;
    Time.timeScale = 1;
  }

  public void OnGUI() {
    if (isGameOver) {
      Cursor.visible = true;
    }
  }

  public void GameOver() {
    isGameOver = true;
    Time.timeScale = 0;
    player.GetComponent<FirstPersonController>().enabled = false;
    player.GetComponent<CharacterController>().enabled = false;
    gameOverPanel.SetActive(true);
  }

  public void RestartGame() {
    SceneManager.LoadScene(Constants.SceneBattle);
    gameOverPanel.SetActive(true);
  }

  public void Exit() {
    Application.Quit();
  }

  public void AddRobotKillToScore() {
    score += 50;
    gameUI.SetScoreText(score);
  }

  IEnumerator increaseScoreEachSecond() {
    while (!isGameOver) {
      yield return new WaitForSeconds(1);
      score += 1;
      gameUI.SetScoreText(score);
    }
  }
}
