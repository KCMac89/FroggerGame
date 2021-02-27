
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;
    public Text livesText;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            // if (livesText.text == "0")
            //{
            //Debug.Log("WE LOST!");
            // Score.currentScore = 0;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //}

            PlayerLives.lives = PlayerLives.lives - 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            if (PlayerLives.lives < 1)
            {
               // Score.currentScore = 0;
                SceneManager.LoadScene("Credits");
            }
        }
    }
}



