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
    void OnCollisionStay2D(Collision2D bol){
        
        if (bol.gameObject.tag == "Uline")
        {
            Debug.Log("I am retard code");
            PlayerController.bend();
            bol.gameObject.tag = "Miline";
            bol.gameObject.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("under");
            StartCoroutine(rejoiner());
            if(canjoin){
            bol.gameObject.tag = "Line";
            bol.gameObject.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("fore");
            StartCoroutine(phelper());}
            if(isdumb){
                bol.gameObject.tag = "Uline";
            }
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