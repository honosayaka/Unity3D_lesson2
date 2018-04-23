using UnityEngine;
using System.Collections;

public class onmouse : MonoBehaviour 
{
	Color c ;
	Vector3 v;
	bool isPlaying;
	// Use this for initialization
	void Start () 
	{
		c = renderer.material.color;
		v = Vector3.up*20;
		isPlaying = false;
	}

	void OnMouseExit()
	{
		renderer.material.color = c;
	}

	void OnMouseOver()
	{
		renderer.material.color = Color.red;
		transform.Rotate (v);
	}

	void OnMouseDown()
	{
		if (!isPlaying) 
		{
			audio.Play ();
			isPlaying = true;
		} else 
		{
			audio.Pause();
			isPlaying = false;
		}

	}

}
