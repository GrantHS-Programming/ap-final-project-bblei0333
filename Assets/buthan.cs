using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buthan : MonoBehaviour
{
    // Start is called before the first frame update
    public Button best_button;
    void Start()
    {
        best_button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick(){
        SceneManager.LoadScene("Level 1");
    }
}
