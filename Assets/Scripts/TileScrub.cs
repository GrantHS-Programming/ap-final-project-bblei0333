using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class TileScrub : MonoBehaviour
{
    public Tilemap map;
    private float scrollPos = 0f;
    public Rigidbody2D Tilemap;
    public Rigidbody2D player;

    private void Start()
    {
        GetComponent<AudioSource>().Play();
        Tilemap = GetComponent<Rigidbody2D>();
        player = GetComponent<Rigidbody2D>();
    }
    void gon(float olo)
    {
        Debug.Log(olo);
        Tilemap tilemap = GetComponent<Tilemap>();
        var tilePos = tilemap.WorldToCell(new Vector3(olo, -1.5f, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3(olo, -2, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3(olo, -3, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3(olo, -4, 0));
        tilemap.SetTile(tilePos, null); 
        tilePos = tilemap.WorldToCell(new Vector3(olo, -5, 0));
        tilemap.SetTile(tilePos, null);       
        tilePos = tilemap.WorldToCell(new Vector3((olo + 0.5f), -1.5f, 0));
        tilemap.SetTile(tilePos, null);   
        tilePos = tilemap.WorldToCell(new Vector3((olo + 0.5f), -2, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo + 0.5f), -3, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo + 0.5f), -4, 0));
        tilemap.SetTile(tilePos, null);   
        tilePos = tilemap.WorldToCell(new Vector3((olo + 0.5f), -5, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo - 0.5f), -1.5f, 0));
        tilemap.SetTile(tilePos, null);    
        tilePos = tilemap.WorldToCell(new Vector3((olo - 0.5f), -2, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo - 0.5f), -3, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo - 0.5f), -4, 0));
        tilemap.SetTile(tilePos, null);
        tilePos = tilemap.WorldToCell(new Vector3((olo - 0.5f), -5, 0));
        tilemap.SetTile(tilePos, null);
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
    void Update()
    {
    transform.position = new Vector2(0.65f, ((GetComponent<AudioSource>().time)*-20));
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2 a = new Vector2(player.position.x, 0);
            Vector2 b = new Vector2(Tilemap.position.x, 0);
            float distance = Vector2.Distance(a, b);
            Debug.Log((transform.position.y*-2)-58);
        }
    }
}