using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
    mousePosition.y = -2;
    if (mousePosition.x < 2.71)
    {
        if (mousePosition.x > -2.71)
        {
            transform.position = mousePosition;
        }
        else transform.position = new Vector2(-2.71f, -2);

    }
    else transform.position = new Vector2(2.71f, -2);
    }
}
