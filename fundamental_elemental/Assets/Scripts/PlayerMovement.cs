using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private Vector2 movement;
    private float playerSpeed = 10.0f;
 
    void Awake()
    { 
        playerBody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");  
    }
    
    void FixedUpdate() 
    { 
        playerBody.MovePosition(playerBody.position + movement * playerSpeed * Time.fixedDeltaTime);
    }

}
