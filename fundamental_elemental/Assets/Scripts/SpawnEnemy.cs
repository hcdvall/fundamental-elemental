using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 14.0f;

    public Transform borderLeft;
    public Transform borderRight;
    public Transform borderTop;
    public Transform borderBottom;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave());
    }


    private void enemySpawner()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);
        
        GameObject a = Instantiate(enemyPrefab) as GameObject;
        a.transform.position = new Vector3(x, y, 0);
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            enemySpawner();
        }
    }
}
