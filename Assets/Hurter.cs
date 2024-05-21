using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Red")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                PlayerController.hurt();
            } 
        } 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
