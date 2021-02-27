using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarSpeed : MonoBehaviour


{
    public static float gameSpeed;
    public Slider mySlider;
    public Text speedText;


    void Update()
    {
       speedText.text = mySlider.value.ToString("");
       mySlider.onValueChanged.AddListener(delegate { ChangeGameSpeed(); });
    }

    public void ChangeGameSpeed()
    {
        gameSpeed = mySlider.value;
    }
}
