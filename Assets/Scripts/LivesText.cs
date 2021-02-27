using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
    
{
  

    private void Start()
    {
        Text livesText = GameObject.Find("Canvas/Lives_txt").GetComponent<Text>();
        livesText.text = "Lives: " + PlayerLives.lives.ToString();
       
    }
}
