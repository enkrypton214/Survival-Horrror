using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetCrashing : MonoBehaviour
{
    [SerializeField] AudioSource crashSound;
    [SerializeField] GameObject theCabinet;
    void OnTriggerEnter(Collider other)
    {
        crashSound.Play();
        if(theCabinet!=null){
        theCabinet.GetComponent<Animator>().Play("CabinetCrashing");}
        this.GetComponent<BoxCollider>().enabled=false;
    }
}
