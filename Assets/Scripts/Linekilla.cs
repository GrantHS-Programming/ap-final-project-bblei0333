using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linekilla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionStay2D(Collision2D bol){
        if((bol.gameObject.tag == "Uline" || bol.gameObject.tag == "Mline") && (PlayerController.hframe == 0)){
            PlayerController.bend();
            PlayerController.displayhit("MISS!");
            bol.gameObject.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("under");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
