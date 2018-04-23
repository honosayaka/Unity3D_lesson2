using UnityEngine;
using System.Collections;

public class light : MonoBehaviour {

	GameObject t;
	// Use this for initialization
	void Start () {
		t = GameObject.Find("GUI Text");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {
			gameObject.light.intensity += 0.2f;
			t.guiText.text = ""+gameObject.light.intensity;
		}
	}
}
