using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    
    [SerializeField] bool canPickUp;
    [SerializeField] GameObject tableKey;
    [SerializeField] GameObject enemy;
    [SerializeField] AudioSource pianoKey;
    [SerializeField] GameObject SeizureTrigger;
    [SerializeField] GameObject doorColseTrigger;
    public bool KeyPresent;

    void Update()
    {
        if (canPickUp==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableKey.SetActive(false);
                KeyPresent=true;
            }
        }
        if (KeyPresent == true)
        {
            enemy.GetComponent<EnemyAI>().WakeUp();
            pianoKey.Play();
            SeizureTrigger.GetComponent<TriggerSeizure>().StopSounds();
            doorColseTrigger.SetActive(true);
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 10
        )
        {
        canPickUp=true;
        UIController.actionText = "Key";
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
