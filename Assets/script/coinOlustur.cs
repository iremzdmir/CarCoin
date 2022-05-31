using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinOlustur : MonoBehaviour
{
    public GameObject coin;
    int kontrol = 0;
    
    void Start()
    {
        do
        {
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(2.5f, 9.5f), 8f, Random.Range(16, 450)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
            
        } while (kontrol < 50);

        do
        {
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(37,67), 8f, Random.Range(491, 500)), Quaternion.EulerAngles(-90, 90, 0));
            kontrol += 1;
        } while (kontrol < 65);

        do
        {
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(95,100), 0.6f, Random.Range(437, 469)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
        } while (kontrol < 70);

        do
        {
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(95, 100), 8f, Random.Range(396,322)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
        } while (kontrol < 75);

        do
        {
            GameObject newCoin = Instantiate(coin, new Vector3(Random.Range(95, 100), 8f, Random.Range(130, 258)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
        } while (kontrol < 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
