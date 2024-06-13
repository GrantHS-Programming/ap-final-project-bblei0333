using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursorhider : MonoBehaviour
{
    // Start is called before the first frame update
    public static int hidden = 1;
    void Start()
    {
        hidden = 1;
        Cursor.visible = false; 
        Cursor.lockState = CursorLockMode.Confined;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hidden == 1){
        Cursor.visible = false; 
        hidden = 2;
        }
        if(hidden == 0){
        Cursor.visible = true; 
        hidden = 2;
        }
    }
}
