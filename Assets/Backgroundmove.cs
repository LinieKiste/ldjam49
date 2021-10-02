using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmove : MonoBehaviour
{

    public new BoxCollider2D collider;
    public Rigidbody2D rb;

    private float width;
    private float scrollSpeed = -20f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        //collider.enable = false;

        //rb.velocity = new Vector2(scrollSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection*scrollSpeed,0);
        
        if(transform.position.x < -width){
            Vector2 resetPosition = new Vector2(width * 2f,0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
