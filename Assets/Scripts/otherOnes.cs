using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherOnes : MonoBehaviour
{
    // Start is called before the first frame update
    float tscroll = 0f;
    private AudioScrub ascrub;
    private float scrollPos = 0f;
    void Start()
    {
        ascrub = GameObject.Find("Tilemap").GetComponent<AudioScrub>();  
        tscroll = ascrub.scrollPos;
    }

    // Update is called once per frame
    void Update()
    {
        scrollPos = tscroll;
        transform.position = new Vector2(0.65f, ((GameObject.Find("Tilemap").GetComponent<AudioSource>().time)*-20));
    }
}
