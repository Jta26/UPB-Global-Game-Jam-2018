using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    private Transform playerTransform;
    public float moveY;
    private bool onGround = true;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 playerPos = playerTransform.position;
            playerPos.x += .1f;
            playerTransform.position = playerPos;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 playerPos = playerTransform.position;
            playerPos.x -= .1f;
            playerTransform.position = playerPos;
        }
        if (Input.GetKey("space"))
        {
            if (onGround)
            {
                moveY = .9f;
                Jump();
            }
            else
            {

            }

        }
        else
        {
            moveY = 0;
        }
    }
    void Jump()
    {
        //Jumping
        //gameObject rb2b =
        onGround = false;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
    private void FixedUpdate()
    {
       
    }
}
