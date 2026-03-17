using System.Collections;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] bool canOpen;
    [SerializeField] AudioSource metalDoorCreak;
    [SerializeField] GameObject theDoor;

    void Update()
    {
        if (canOpen==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(OpeningDoor());
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
        canOpen=true;
        UIController.actionText = "Open Door";
        UIController.commandText = " Open";
        UIController.UIActive = true;
        }
        else
        {
        canOpen=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
        }
    }
    void OnMouseExit()
    {
        canOpen=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
    }

    IEnumerator OpeningDoor()
    {
        metalDoorCreak.Play();
        theDoor.GetComponent<Animator>().Play("MetalDoorOpen");
        this.gameObject.GetComponent<BoxCollider>().enabled=false;
        yield return new WaitForSeconds(2);
    }
}
