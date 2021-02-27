using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

   private void Start()
    {
        Text highScoreText = GameObject.Find("Canvas/Score_txt").GetComponent<Text>();
        highScoreText.text = "Score: " + Score.currentScore.ToString();
    }

}
