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
        //enemyBody = GetComponent<Rigidbody2D>();
        //GameObject enemyGo = Instantiate(enemyPrefab) as GameObject;
        //enemyGo.transform.position = new Vector3(3f,3f,1f); 
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
