using UnityEngine;

public class CandleRandom : MonoBehaviour
{
    [SerializeField] int candleLocation;
    [SerializeField] GameObject candle1;
    [SerializeField] GameObject candle2;
    [SerializeField] GameObject candle3;   
    [SerializeField] GameObject candle4;

    void Start()
    {
        candleLocation = Random.Range(4,5);
        if (candleLocation == 1)
        {
            candle1.SetActive(true);
        }
        if (candleLocation == 2)
        {
            candle2.SetActive(true);
        }
        if (candleLocation == 3)
        {
            candle3.SetActive(true);
        }
        if (candleLocation == 4)
        {
            candle4.SetActive(true);
        }
    }
}
