using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EasySave : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    public void PlayerPrefSave()
    {
        PlayerPrefs.SetString("lives", livesText.text);
        PlayerPrefs.SetString("score", scoreText.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("scene", SceneManager.GetActiveScene().name);
       
    }
   

}
