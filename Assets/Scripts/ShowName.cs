using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShowName : MonoBehaviour
{
    public Text nameBox;



    private void Start()
    {
        nameBox.text = PlayerPrefs.GetString("name");
    }


}
