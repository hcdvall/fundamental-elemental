using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter2D(Collision2D collisionInfo) {
        if(collisionInfo.gameObject.tag == "Enemy")
        {
            movement.enabled = false;
        }
    }
        
}
