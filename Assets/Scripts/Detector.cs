using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sam;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Detector")
        {
            BroadcastMessage("flash");
        }  
    }
    void Start()
    {
    }
    void flash()
    {
        //nothin
    }

    // Update is called once per frame
    void Update()
    {
    }
}
