using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D enemyBody;
    //public Transform player;
    public GameObject player;
    public Vector2 destination;
    private float enemySpeed = 5.0f;
    public Vector3 direction;
    
    void Start() 
    {
        enemyBody = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {   
        direction = (player.transform.position - transform.position).normalized;
    }

    void FixedUpdate() 
    {
        enemyBody.MovePosition(
            transform.position + direction * enemySpeed * Time.fixedDeltaTime);
    }

}
