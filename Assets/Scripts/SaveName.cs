
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour

{

    public InputField textBox;

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("Your Name is " + PlayerPrefs.GetString("name"));
    }
}
