using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public int lane;
    public int health = 3;
    private float iframe = 0;
    private static int combo = 0;
    public Font fonty;
    public BoxCollider2D conan;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "normie")
        {
            if ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time) > 1.4f)
            {
                combo++;
            } 
        }
            if (other.gameObject.tag == "Red")
        {

            if(iframe == 0)
            {
                iframe = 1;
                combo = 0;
                health--;
            }


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
    public static void bend()
    {
        combo = 0;
    }
    IEnumerator waitFunction1()
    {
        yield return new WaitForSeconds(1);
        iframe = 0;
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
        if(iframe == 1){
            StartCoroutine(waitFunction1());
            iframe = 2;
        }

    }
    void OnGUI()
    {        
        GUIStyle headStyle = new GUIStyle();
        headStyle.fontSize = 60;
        headStyle.normal.textColor = Color.white;
        headStyle.font = fonty;
        GUIStyle sub = new GUIStyle();
        sub.fontSize = 30;
        sub.normal.textColor = Color.white;
        sub.font = fonty;
        GUI.Label(new Rect(((Screen.width/4)*3), (Screen.height/2), 50, 50), "Lives:  \n"+health, headStyle);
        GUI.Label(new Rect(((Screen.width/4)*3), ((Screen.height/2)+200), 50, 50), "Combo:  "+combo, sub);


    }
}
