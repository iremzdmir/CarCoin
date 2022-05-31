using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinYoket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car")
        {

            skor.score += 5;
            Destroy(this.gameObject);

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
