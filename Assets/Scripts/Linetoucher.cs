using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linetoucher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionExit2D(Collision2D lol){
        if(lol.gameObject.tag == "Line"){
            PlayerController.otouch = 1;
            PlayerController.linet = true;
        }
    }
    void OnCollisionStay2D(Collision2D bro){
        if(bro.gameObject.tag == "Line"){
            if(PlayerController.hframe == 0){    
                PlayerController.hframe = 1;
            PlayerController.ding();
            PlayerController.displayhit("PERFECT!");
            PlayerController.addscore(100 * ((PlayerController.combo / 10) + 1));
            }
            PlayerController.otouch = 0;
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
