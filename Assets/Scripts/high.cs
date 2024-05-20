using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class high : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "normie")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                ding();
                addscore(100);
            } 
        }
        if (other.gameObject.tag == "Red")
        {
            hurt();
        } 
    }
        void OnCollisionStay2D(Collision2D col)
    {
        if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
       {
           SendMessageUpwards("gon", transform.position.x);
       }
    }
    void gon()
    {
        //nuthin
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

