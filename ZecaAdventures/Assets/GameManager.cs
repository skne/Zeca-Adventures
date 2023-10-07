using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool gameIsOver = false;
  public float menuDelay = 1f;
  public float transitionDelay = 3f;

  public GameObject _startingSceneTransition;
  public GameObject _endingSceneTransition;

  private void Start()
  {
    _startingSceneTransition.SetActive(true);
    Invoke("DisableStartingSceneTransition", transitionDelay);
    Debug.Log("Start");
  }
  private void DisableStartingSceneTransition()
  {
    _startingSceneTransition.SetActive(false);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Debug.Log("Update");
      _endingSceneTransition.SetActive(true);
      Invoke("Menu", menuDelay);
      
    }
  }
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
    _endingSceneTransition.SetActive(true);
    SceneManager.LoadScene("GameOverScreen");
  }
}
