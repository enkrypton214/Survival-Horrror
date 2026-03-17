using System.Collections;
using UnityEngine;

public class Notes : MonoBehaviour
{
    bool canInteract;
    [SerializeField] GameObject NotesCanvas;

    void Update()
    {
        if (canInteract==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(NotesDisplay());
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
        canInteract=true;
        UIController.actionText = "Notes";
        UIController.commandText = " Read";
        UIController.UIActive = true;
        }
        else
        {
        canInteract=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
        }
    }
    void OnMouseExit()
    {
        canInteract=false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.UIActive = false;
    }

   IEnumerator NotesDisplay()
   {
    NotesCanvas.SetActive(true);
    yield return new WaitForSeconds(5);
    NotesCanvas.SetActive(false);
   }
}
