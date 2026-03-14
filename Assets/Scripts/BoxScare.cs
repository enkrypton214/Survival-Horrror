using UnityEngine;

public class BoxScare : MonoBehaviour
{
    public GameObject boxHolder;

    void OnTriggerEnter(Collider collider)
    {
        boxHolder.SetActive(false);
    }
}
