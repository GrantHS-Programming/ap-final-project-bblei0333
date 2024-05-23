using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Red")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                Debug.Log("Hurt");
                PlayerController.hurt();
            } 
        } 
        if (other.gameObject.tag == "Line")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                Debug.Log("Hit");
                PlayerController.holdchange(1);
            } 
        } 
    }
    void OnCollisionExit2D(Collision2D oth){
        if(oth.gameObject.tag == "Line"){
            Debug.Log("Hit");
            PlayerController.holdchange(0);
        }
    }
    // Update is called once per frame
    void Update()
    {        
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
    mousePosition.y = -2f;
    if (mousePosition.x < 2.71)
    {
        if (mousePosition.x > -2.71)
        {
            transform.position = mousePosition;
        }
        else transform.position = new Vector2(-2.71f, -2f);

    }
    else transform.position = new Vector2(2.71f, -2f);
    }
}
