using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject background;
    private void OnCollisionEnter2D(Collision2D collisionInfo) {
        if(collisionInfo.gameObject.tag == "Enemy")
        {
            movement.enabled = false;
            background.SetActive(true);
        }
    }
        
}
