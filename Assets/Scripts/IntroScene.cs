using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
  public void LoadIntroScene()
    {
        Score.currentScore = 0;
        SceneManager.LoadScene("Intro");
    }
}
