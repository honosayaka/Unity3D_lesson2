using UnityEngine;
using System.Collections;

public class pickcell : MonoBehaviour {

    // Use this for initialization
    public static int pickedCell = 0;
    public Texture2D[] buater;
    public GUITexture t;
    public Texture2D[] genter;
    public Renderer g;
    public GameObject alarmlight;

    private GameObject text;
    void Start() {
        text = GameObject.Find("picked");
    }

    public void pickCell() {
        pickedCell++;
        text.guiText.text = "picked:\t" + pickedCell;
        t.texture = buater[pickedCell];
        g.material.mainTexture = genter[pickedCell];
        if (pickedCell>=4)
        {
            alarmlight.GetComponent<Light>().color = Color.green;
        }
    }
}
