using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSeizure : MonoBehaviour
{
   [SerializeField] GameObject enemy;
   [SerializeField] AudioSource bedShaking; 

   public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            enemy.GetComponent<EnemyAI>().Seizure();
            bedShaking.Play();
            this.GetComponent<BoxCollider>().enabled=false;
        }
    }
    public void StopSounds()
    {
        bedShaking.Stop();
    }
}
