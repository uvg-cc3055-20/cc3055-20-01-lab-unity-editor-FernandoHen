using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
   
    Rigidbody2D rb;
    public float jumpForce = 0.0001f;
    public float forwardSpeed = 2f;
    public float sky = 0.2f;
    public bool dead= false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    
    
    
    // Update is called once per frame
    void Update()
    {   

        if (dead.Equals(false))
        {
            rb = GetComponent<Rigidbody2D>();
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);

            }

            rb.transform.Translate(new Vector3(2, 0, 0) * forwardSpeed * Time.deltaTime);

        }
        if (rb.position.x >= 53.92)
        {
            dead = true;
        }


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
    
    
    
}
