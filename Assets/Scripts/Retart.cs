using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retart : MonoBehaviour
{
    // Start is called before the first frame update
    public Button bet_button;
    public static int endr = 0;
    void Start()
    {
        endr = 0;
        bet_button.onClick.AddListener(TaskOnClick);
        transform.position = new Vector2(40, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(endr == 1){
        transform.position = new Vector2(0, 0.5f);
        }
    }
    void TaskOnClick(){
        carrier.lmode = 0;
        carrier.hmode = 0;
        carrier.offsetmode = false;
        SceneManager.LoadScene("Menu");
    }
}
