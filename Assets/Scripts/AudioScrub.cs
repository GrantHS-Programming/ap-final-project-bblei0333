

using UnityEngine;
using System.Collections;

public class AudioScrub : MonoBehaviour
{

    public float scrollPos = 0f;

    private void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    private void OnGUI()
    {
        scrollPos = GUI.HorizontalSlider(new Rect(0f, 50f, Screen.width, 50f), scrollPos, 0, GetComponent<AudioSource>().clip.length);
        if (GUI.changed == true)
        {
            GetComponent<AudioSource>().time = scrollPos;
        }

        GUI.Label(new Rect(10f, 80f, 100f, 30f), (GetComponent<AudioSource>().time).ToString());
    }
}