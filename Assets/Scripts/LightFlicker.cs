using System.Collections;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] GameObject lightSource;
    [SerializeField] float minTime = 0.05f;
    [SerializeField] float maxTime = 0.3f;

    void Start()
    {
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            lightSource.SetActive(!lightSource.activeSelf);
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        }
    }
}