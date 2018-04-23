using UnityEngine;
using System.Collections;

public class doormanager : MonoBehaviour {

	private bool doorIsClosed = true;
	public AudioClip dooropensound;
	public AudioClip doorclosesound;
	private GameObject door;
	private float time = 0f;

	// Use this for initialization
	void Start () {
	
	}
    /*void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "player") {
             openDoor();
        }
     
    }*/
	// Update is called once per frame
	void Update () {
		if (!doorIsClosed) {
			time += Time.deltaTime;
			if (time >= 3f) {
				closeDoor();	
				time = 0f;
			}	
		}
	}

	private void openDoor()
    {
		doorIsClosed = false;
		audio.PlayOneShot(dooropensound);	
		transform.parent.animation.Play ("opendoor");
	}
	private void closeDoor()
    {
		doorIsClosed = true;
		audio.PlayOneShot(doorclosesound);	
		transform.parent.animation.Play ("closedoor");
	}
}
