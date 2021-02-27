
using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D rb;
    //public float minSpeed = 8f;
    //public float maxSpeed = 12f;
   
    //float speed = 5f;

    void Start()
    {
       // speed = Random.Range(minSpeed, maxSpeed);
        Destroy(gameObject, 9f);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * CarSpeed.gameSpeed);
        
        //rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
