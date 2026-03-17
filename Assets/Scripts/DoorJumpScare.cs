using UnityEngine;

public class DoorJumpScare : MonoBehaviour
{
    [SerializeField] AudioSource pianoScare;
    [SerializeField] AudioSource doorSlam;
    [SerializeField] GameObject theDoor;
    [SerializeField] GameObject screamTriggerActive;

    void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("JumpAnimDoor");
        pianoScare.Play();
        doorSlam.Play();
        this.GetComponent<BoxCollider>().enabled=false;
        screamTriggerActive.SetActive(true);
    }
}
