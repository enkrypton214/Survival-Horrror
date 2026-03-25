using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetalDoor : MonoBehaviour
{

    [SerializeField] bool canOpen;
    [SerializeField] GameObject thePlayer; 
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] AudioSource lockedDoor;
    [SerializeField] KeyPickup keyPickup;
    [SerializeField] GameObject ScreenFade;

    void Update()
    {
        if (canOpen==true)
        {
            if (Input.GetKeyDown(KeyCode.E) && keyPickup.KeyPresent==false)
            {
                StartCoroutine(OpeningDoor());
            }
            if( keyPickup.KeyPresent==true && Input.GetKeyDown(KeyCode.E))
            {
                ScreenFade.SetActive(true);
                StartCoroutine(EndGame());
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
        theCam.SetActive(true);
        thePlayer.SetActive(false);
        textOnScreen.SetActive(true);
        lockedDoor.Play();
        yield return new WaitForSeconds(2);
        textOnScreen.SetActive(false);
        thePlayer.SetActive(true);
        theCam.SetActive(false);
    }
    
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }

}
