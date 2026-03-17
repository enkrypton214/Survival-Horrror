using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class CandlePickUp : MonoBehaviour
{

    [SerializeField] bool canPickUp;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] GameObject webEventTrigger;
    void Update()
    {
        if (canPickUp==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(false);
                handCandle.SetActive(true);
                webEventTrigger.SetActive(true);
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
        canPickUp=true;
        UIController.actionText = "Candle";
        UIController.commandText = " Pick Up";
        UIController.UIActive = true;
        }
        else
        {
        canPickUp=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
        }
    }
    void OnMouseExit()
    {
        canPickUp=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
    }

}
