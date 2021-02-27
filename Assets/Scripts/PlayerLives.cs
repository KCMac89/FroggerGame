using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public Dropdown dropdown;
    public static int lives;

    public void NumberOfLives()
    {
        switch (dropdown.value)
        {
            default:
                lives = 3;
                break;
            case 1:
                lives = 3;
                break;
            case 2:
                lives = 2;
                break;
            case 3:
                lives = 1;
                break;

        }
    }


   
}
