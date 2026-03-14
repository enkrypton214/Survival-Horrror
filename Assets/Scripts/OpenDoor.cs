using System.Collections;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] bool canOpen = true;
    [SerializeField] GameObject textOnScreen;
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
        textOnScreen.SetActive(true);
        metalDoorCreak.Play();
        theDoor.GetComponent<Animator>().Play("MetalDoorOpen");
        yield return new WaitForSeconds(2);
        textOnScreen.SetActive(false);
    }
}
