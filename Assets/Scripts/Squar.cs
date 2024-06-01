using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squar : MonoBehaviour
{
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    IEnumerator flash()
    {
        sprite.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.05f);
        sprite.color = new Color(0, 0, 0, 0);
    }
    void Update()
    {
        
    }
}
