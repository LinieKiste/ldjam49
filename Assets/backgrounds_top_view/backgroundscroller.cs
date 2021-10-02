using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroller : MonoBehaviour
{
    public new BoxCollider2D collider2D;
    public Rigidbody2D rb;

private float height;
private float scrollSpeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = collider2D.size.y;
        collider2D.enabled = false;

        rb.velocity = new Vector2(0, scrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height)
        {
            Vector2 resetPosition = new Vector2(0, height * 2f);
            transform.position = (Vector2) transform.position + resetPosition;
        }
    }
}
