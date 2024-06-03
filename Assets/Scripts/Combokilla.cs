using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combokilla : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dave;
    private bool canjoin = false;
    private bool isdumb = false;
       
    IEnumerator rejoiner()
    {
        yield return new WaitForSeconds(1);
        
            canjoin = true;
            Debug.Log("1");

    }
    IEnumerator phelper()
    {
        yield return new WaitForSeconds(1);
        
            isdumb = true;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "normie")
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