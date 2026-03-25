using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlam : MonoBehaviour
{
    [SerializeField] AudioSource doorSlam;
    [SerializeField] GameObject theDoor;
    [SerializeField] GameObject enemy;

    void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("JumpAnimDoorClose");
        doorSlam.Play();
        this.GetComponent<BoxCollider>().enabled=false;
        enemy.GetComponent<EnemyAI>().BreathingSound();
    }
}
