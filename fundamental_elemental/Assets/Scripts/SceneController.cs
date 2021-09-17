using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject puddlePrefab;
    [SerializeField] private GameObject firePrefab;
    private GameObject puddle;
    private GameObject fire;
    public Transform borderLeft;
    public Transform borderRight;
    public Transform borderTop;
    public Transform borderBottom;
    public GameOverScreen GameOverScreen;

    void Start() 
    {
        InvokeRepeating("puddleSpawn", 0, 10);
        InvokeRepeating("fireSpawn", 0, 9);
    }

    void puddleSpawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);

        puddle = Instantiate(puddlePrefab) as GameObject;
        puddle.transform.position = new Vector2(x, y);
        
        Destroy(puddle, 6);
    }

    void fireSpawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);

        fire = Instantiate(firePrefab) as GameObject;
        fire.transform.position = new Vector2(x, y);

        Destroy(fire, 10);
    }

    public void GameOver()
    {
        GameOverScreen.Setup(10);
    }

}
