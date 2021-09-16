using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    //[SerializeField] private GameObject enemyPrefab;
    //public GameObject enemyPrefab;
    //public float respawnTime = 4.0f;
    [SerializeField] private GameObject puddlePrefab;
    [SerializeField] private GameObject firePrefab;
    //private GameObject enemy;
    private GameObject puddle;
    private GameObject fire;
    private Collider2D puddleCollider;
    private Collider2D fireCollider;

    public Transform borderLeft;
    public Transform borderRight;
    public Transform borderTop;
    public Transform borderBottom;


    void Start() 
    {
        InvokeRepeating("puddleSpawn",0, 10);
        InvokeRepeating("fireSpawn",0, 10);
    }

    void puddleSpawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);

        puddle = Instantiate(puddlePrefab) as GameObject;
        puddle.transform.position = new Vector2(x, y);
        Destroy(puddle, 8);
    }

    void fireSpawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);

        fire = Instantiate(firePrefab) as GameObject;
        fire.transform.position = new Vector2(x, y);
        fireCollider = fire.GetComponent<Collider2D>();
        Debug.Log(fireCollider.isTrigger);
        fireCollider.isTrigger = true;
        Destroy(fire, 10);
    }
}
