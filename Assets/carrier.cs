using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrier : MonoBehaviour
{
    // Start is called before the first frame update
    public static int lmode = 0;
    public static bool offsetmode = false;
    public static int hmode = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
