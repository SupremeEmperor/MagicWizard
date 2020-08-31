using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 1;
    [SerializeField]
    float dashMultplier = 2;
    [SerializeField]
    float jumpHeight = 1;

    Rigidbody2D rb;
    float verticalSpeed = 0;
    [SerializeField]
    bool jumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float mult;
        if (Input.GetAxis("Jump") > 0)
        {
            mult = dashMultplier;
        }else
        {
            mult = 1;
        }
        if(Input.GetAxis("Horizontal") > 0.001f)
        {
            Debug.Log("right");
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
            rb.velocity = new Vector2(1 * speed * mult, rb.velocity.y);

        }
        else if (Input.GetAxis("Horizontal") < -0.001f)
        {
            Debug.Log("left");
            this.transform.rotation = new Quaternion(0, 180, 0, 0);
            rb.velocity = new Vector2(-1 * speed * mult, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        

        if(Input.GetAxis("Fire3") > 0 && jumping == false)
        {
            Debug.Log("jump");
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0, 1 * jumpHeight));
            jumping = true;
        } else if (Input.GetAxis("Fire3") == 0)
        {
            jumping = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        jumping = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jumping = true;
    }
}
