using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionStay2D(Collision2D bro){
        if (bro.gameObject.tag == "Red")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                PlayerController.hurt();
                Debug.Log(bro.gameObject);
            } 
        } 
    }
    // Update is called once per frame
    void Update()
    {        
    }
}
