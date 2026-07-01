using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    Rigidbody2D rb;
    float movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        plyerrun();
    }

    void plyerrun()
    {
        movement = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 20f;
            rb.linearVelocity = new Vector2(movement * speed, rb.linearVelocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
            rb.linearVelocity = new Vector2(movement * speed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(movement * speed, rb.linearVelocity.y);
        }
        
    }
}
