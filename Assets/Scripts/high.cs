using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class high : MonoBehaviour
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
                if(PlayerController.cframe == 0)
                {
                    PlayerController.ding();
                    PlayerController.addscore(100 * ((PlayerController.combo / 10) + 1));
                    PlayerController.displayhit("PERFECT!");
                    PlayerController.cframer();
                }
            } 
        } 
    }
    void OnCollisionStay2D(Collision2D col)
    {
    if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
        {
            if(col.gameObject.tag == "normie")
            {
                SendMessageUpwards("hitsend",(transform.position.x));
            }       
        }
    }
    void hitsend(){
        //nuthin
    }
    // Update is called once per frame
    void Update()
    {        
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
    mousePosition.y = -1.5f;
    if (mousePosition.x < 2.71)
    {
        if (mousePosition.x > -2.71)
        {
            transform.position = mousePosition;
        }
        else transform.position = new Vector2(-2.71f, -1.5f);

    }
    else transform.position = new Vector2(2.71f, -1.5f);
    }
}

