using UnityEngine;

public class UIController : MonoBehaviour
{
    public static string actionText;
    public static string commandText;
    public static bool UIActive;

    [SerializeField] GameObject actionBox;
    [SerializeField] GameObject commandBox;
    [SerializeField] GameObject interactCross;

    void Start()
{
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
    void Update()
    {
        if (UIActive == true)
        {
            actionBox.SetActive(true);
            commandBox.SetActive(true);
            interactCross.SetActive(true);
            actionBox.GetComponent<TMPro.TextMeshProUGUI>().text=actionText;
            commandBox.GetComponent<TMPro.TextMeshProUGUI>().text="[E]" + commandText;
        }
        else
        {
            actionBox.SetActive(false);
            commandBox.SetActive(false);
            interactCross.SetActive(false);
        }
    }

}
