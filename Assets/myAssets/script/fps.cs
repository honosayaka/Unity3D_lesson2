using UnityEngine;
using System.Collections;

public class fps : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		gameObject.guiText.text = "fps: " + 1/Time.deltaTime;
	}
}
