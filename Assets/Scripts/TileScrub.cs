using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class TileScrub : MonoBehaviour
{
    public Tilemap map;
    private AudioScrub ascrub;
    private float scrollPos = 0f;
    public Rigidbody2D Tilemap;
    public Rigidbody2D player;
    float tscroll = 0f;

    private void Start()
    {
        ascrub = GameObject.Find("Tilemap").GetComponent<AudioScrub>();
        GetComponent<AudioSource>().Play();
        Tilemap = GetComponent<Rigidbody2D>();
        player = GetComponent<Rigidbody2D>();
        tscroll = ascrub.scrollPos;
    }
    void gon(float olo)
    {
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
    void Update()
    {
        scrollPos = tscroll;
    transform.position = new Vector2(0.65f, ((GetComponent<AudioSource>().time)*-20));
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.K))
        {
            Vector2 a = new Vector2(player.position.x, 0);
            Vector2 b = new Vector2(Tilemap.position.x, 0);
            float distance = Vector2.Distance(a, b);
            Debug.Log(((transform.position.y)*-2)-60);
        }
    }
}