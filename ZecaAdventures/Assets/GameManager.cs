using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool gameIsOver = false;
  public float menuDelay = 1f;

  public void GameOver()
  {
    if(gameIsOver==false)
    {
      gameIsOver=true;
      Debug.Log("Game Over");
      Invoke("Menu", menuDelay);
    }
  }
  void Menu()
  {
    SceneManager.LoadScene("GameOverScreen");
  }
}
