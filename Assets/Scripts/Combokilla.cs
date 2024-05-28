using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combokilla : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dave;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "normie")
        {
            PlayerController.bend();
        } 
        
    }
    void OnCollisionStay2D(Collision2D bol){
        
        if (bol.gameObject.tag == "Line" && PlayerController.linet == false)
        {
            PlayerController.bend();
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
