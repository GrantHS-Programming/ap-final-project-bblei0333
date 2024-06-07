using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ender : MonoBehaviour
{
    public static int ending = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update(){
        if(ending == 1){
            over();
            ending = 2;
        }
    }
    public void over(){
        transform.position = new Vector2(0, 0.8f);
    }
}
