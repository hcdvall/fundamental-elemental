using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 5.0f;
    public Transform borderLeft;
    public Transform borderRight;
    public Transform borderTop;
    public Transform borderBottom;

    public Vector3 fireLocation;
    
    void Start()
    {
        StartCoroutine(enemySpawner());
    }

    IEnumerator enemySpawner()
    {
        while(true) {
            yield return new WaitForSeconds(respawnTime);

            int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
            int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);
            
            GameObject a = Instantiate(enemyPrefab) as GameObject;
            fireLocation = GameObject.FindWithTag("Fire").transform.position;
            //a.transform.position = new Vector3(x, y, 0);
            a.transform.position = fireLocation;
        }
    }
    
}
