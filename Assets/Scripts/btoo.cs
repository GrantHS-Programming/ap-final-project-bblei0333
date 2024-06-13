using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class btoo : MonoBehaviour
{
    // Start is called before the first frame update
    public Button b1;
    public TextMeshProUGUI b1text;
    public bool tf = false;
    void Start()
    {
        b1.onClick.AddListener(TaskOnClick);
        b1text = b1.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick(){
        if(tf == false){
        carrier.offsetmode = carrier.offsetmode = true;
        b1text.text = "Bluetooth offset on";
        tf = true;
        }
        else{
        carrier.offsetmode = carrier.offsetmode = false;
        b1text.text = "Bluetooth offset off";
        tf = false;
        }

    }
}
