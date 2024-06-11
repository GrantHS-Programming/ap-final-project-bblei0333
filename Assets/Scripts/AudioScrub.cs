

using UnityEngine;
using System.Collections;

public class AudioScrub : MonoBehaviour
{

    public float scrollPos = 0f;
    public float spos = 20f;
    public static int endt = 0;

    private void Start()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().time += spos;
    }

    private void OnGUI()
    {
        scrollPos = GUI.HorizontalSlider(new Rect(0f, -250f, Screen.width, 50f), scrollPos, 0, GetComponent<AudioSource>().clip.length);
        if (GUI.changed == true)
        {
            GetComponent<AudioSource>().time = scrollPos;
            Debug.Log("Not here");
        }

        GUI.Label(new Rect(10f, 80f, 100f, 30f), (GetComponent<AudioSource>().time).ToString());
    }
    private void Update(){
        if(GetComponent<AudioSource>().time > 143){
            ender.ending = 1;
            PlayerController.exploder = 100000;
        }
        if(endt == 1){
        GetComponent<AudioSource>().time = 145;
        endt = 2;
        }
    }
    
}