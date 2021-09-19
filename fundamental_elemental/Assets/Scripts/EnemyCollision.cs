using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private float timeToShrink = 0.2f;
    IEnumerator OnTriggerEnter2D(Collider2D collisionInfo) {
        if(collisionInfo.gameObject.tag == "Puddle")
        {
            Vector3 enemyMinSize = new Vector3(0.4f, 0.4f, 1);
            if(transform.localScale == enemyMinSize)
            {
                Destroy(this.gameObject);
            }
            else 
            {
                yield return new WaitForSeconds(timeToShrink);
                transform.localScale -= new Vector3(0.2f, 0.2f, 0);
            }
        }
        else if(collisionInfo.gameObject.tag == "Fire")
        {
            transform.localScale += new Vector3(0.2f, 0.2f, 0);     
        }
        
    }
}
