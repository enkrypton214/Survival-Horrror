using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class WebBurn : MonoBehaviour
{

    [SerializeField] bool canBurn;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerCandle;
    [SerializeField] GameObject webCam;
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject flameObject;
    [SerializeField] GameObject webObjects;
    void Update()
    {
        if (canBurn==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                StartCoroutine(BurnWeb());
                playerCandle.SetActive(false);
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
        canBurn=true;
        UIController.actionText = "SpiderWeb";
        UIController.commandText = " Burn";
        UIController.UIActive = true;
        }
        else
        {
        canBurn=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
        }
    }
    void OnMouseExit()
    {
        canBurn=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
    }

    IEnumerator BurnWeb()
        {
            webCam.SetActive(true);
            thePlayer.SetActive(false);
            flameObject.SetActive(true);
            yield return new WaitForSeconds(3);
            fadeIn.SetActive(false);
            fadeIn.SetActive(true);
            webObjects.SetActive(false);
            flameObject.SetActive(false);
            thePlayer.SetActive(true);
            webCam.SetActive(false);
        }
}
