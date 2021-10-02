using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool jump = false;

    public bool grounded = true;

    public float jumpForce = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!grounded && rb.velocity.y == 0){
            grounded = true;
        }
        jump = Input.GetKeyDown("up");
        if (jump && grounded == true){
            rb.AddForce(transform.up*jumpForce,ForceMode2D.Impulse);
            grounded = false;
        }
    }
}
