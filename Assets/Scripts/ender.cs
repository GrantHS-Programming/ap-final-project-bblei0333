using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ender : MonoBehaviour
{
private static int misscount = 0;
private static float gradenum = 0f;
private static int hits = 0;
private static string grade = "";
public static int ending = 0;
private static int labeller = 0;
private static int pcount = 0;
private static int ocount = 0;
private static int bcount = 0;
public Font fonty;
    // Start is called before the first frame update
    void Start()
    {
    misscount = 0;
    gradenum = 0f;
    hits = 0;
    grade = "";
    ending = 0;
    labeller = 0;
    pcount = 0;
    ocount = 0;
    bcount = 0;
    }
    void Update(){
        if(ending == 1){
            over();
            ending = 2;
        }
    }
    public void OnGUI(){
        GUIStyle big = new GUIStyle();
        big.fontSize = 200;
        big.normal.textColor = Color.white;
        big.font = fonty;
        big.alignment = TextAnchor.MiddleCenter;
        GUIStyle counts = new GUIStyle();
        counts.fontSize = 30;
        counts.normal.textColor = Color.white;
        counts.font = fonty;
        counts.alignment = TextAnchor.MiddleCenter;
        GUIStyle accu = new GUIStyle();
        accu.fontSize = 20;
        accu.normal.textColor = Color.white;
        accu.font = fonty;
        accu.alignment = TextAnchor.MiddleCenter;
        if(labeller == 1){
        GUI.Label(new Rect(((Screen.width/2)), ((Screen.height/3)), 50, 50), ""+ grade, big);
        GUI.Label(new Rect(((Screen.width/2)), ((Screen.height/6)*3), 50, 50), "SCORE:    "+ PlayerController.score, counts);
        GUI.Label(new Rect(((Screen.width/6)), ((Screen.height/6)*4), 50, 50), "PERFECTS:    "+ pcount, counts);
        GUI.Label(new Rect(((Screen.width/6)* 3), ((Screen.height/6)*4), 50, 50), "OKS:    "+ ocount, counts);
        GUI.Label(new Rect(((Screen.width/6)* 5), ((Screen.height/6)*4), 50, 50), "BADS:    "+ bcount, counts);
        GUI.Label(new Rect(((Screen.width/6)* 3), ((Screen.height/32)*25), 50, 50), "MISSES:    "+ misscount, counts);
        GUI.Label(new Rect(((Screen.width/6)* 3), ((Screen.height/8)*7), 50, 50), "Hits taken:    "+ hits, counts);
        GUI.Label(new Rect(((Screen.width/2)), ((Screen.height/8)), 50, 50), "Accuracy:   "+ gradenum + "%", accu);
        }
    }
    public void over(){
        Cursorhider.hidden = 0;
        AudioScrub.endt = 1;
        Retart.endr = 1;
        transform.position = new Vector2(0, 0.8f);
        misscount = PlayerController.misses;
        pcount = PlayerController.ps;
        ocount = PlayerController.os;
        bcount = PlayerController.bs;
        gradenum = ((PlayerController.score * 100f)/22000f);
        gradenum = Mathf.Round(gradenum * 10.0f) * 0.1f;
        hits = PlayerController.hitcount;
        labeller = 1;
        Debug.Log(gradenum);
        if(gradenum < 31){
            grade = "F";
        }
        else if(gradenum < 51){
            grade = "D";
        }
        else if(gradenum < 76){
            grade = "C";
        }
        else if(gradenum < 91){
            grade = "B";
        }
        else if(misscount == 0 && hits == 0){
            grade = "FC";
        }
        else if(gradenum < 96){
            grade = "A";
        }
        else if(gradenum < 98){
            grade = "S";
        }
        else{
            grade = "SS";
        }
    }
}
