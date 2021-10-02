using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, 0);
    }
}
