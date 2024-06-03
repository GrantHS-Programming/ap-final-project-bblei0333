using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public static string thehit = " ";
    public static bool linet = false;
    public static int score = 0;
    public static int health = 3;
    private static float iframe = 0;
    public static float cframe = 0;
    public static float hframe = 0;
    public static int combo = 0;
    public Font fonty;
    private int mater = 30;
    private static int coostart = 0;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    public static void bend()
    {
        combo = 0;
        if(cframe == 0)
        {
        }
    }
    IEnumerator waitFunction1()
    {
        yield return new WaitForSeconds(1);
        iframe = 0;
    }    
    IEnumerator waitFunction2()
    {
        yield return new WaitForSeconds(0.05f);
        cframe = 0;
    }    
    IEnumerator waitFunction3()
    {
        yield return new WaitForSeconds(0.125f);
        hframe = 0;
    }
    IEnumerator waitFunction4()
    {
        yield return new WaitForSeconds(0.03125f);
        mater = 26;
        yield return new WaitForSeconds(0.03125f);
        mater = 27;
        yield return new WaitForSeconds(0.03125f);
        mater = 28;
        yield return new WaitForSeconds(0.03125f);
        mater = 29;
        yield return new WaitForSeconds(0.03125f);
        mater = 30;
    }
    public static void cframer(){
        cframe = 1;
    }
    public static void addscore(int numb){
        score = score + numb;
    }
    public static void displayhit(string thit){
        //Debug.Log(thit);
        coostart = 1;
        thehit = thit;
        
    }
    public static void hurt(){
        if(iframe == 0){
            iframe = 1;
            combo = 0;
            health--;
        }

    }
    public static void ding(){
        if(cframe == 0){
            combo++;     
        }

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
        if(cframe == 1){
            StartCoroutine(waitFunction2());
            cframe = 2;
        }
        if(hframe == 1){
            StartCoroutine(waitFunction3());
            hframe = 2;
        }
        if(coostart == 1){
            StartCoroutine(waitFunction4());
            coostart = 2;
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
        GUIStyle sub2 = new GUIStyle();
        sub2.fontSize = 30;
        sub2.normal.textColor = Color.white;
        sub2.font = fonty;
        GUIStyle hitch = new GUIStyle();
        hitch.fontSize = mater;
        hitch.normal.textColor = Color.white;
        hitch.font = fonty;
        hitch.alignment = TextAnchor.MiddleCenter;
        GUI.Label(new Rect(((Screen.width/4)*3), (Screen.height/2), 50, 50), "Lives:  \n"+health, headStyle);
        GUI.Label(new Rect(((Screen.width/4)*3), ((Screen.height/2)+200), 50, 50), "Combo:  "+combo, sub);
        GUI.Label(new Rect(((Screen.width/4)*3), ((Screen.height/2)+300), 50, 50), "Score:  "+score, sub2);
        GUI.Label(new Rect(((Screen.width/2) -30), ((Screen.height/20)*19), 50, 50), thehit, hitch);
    }
}
