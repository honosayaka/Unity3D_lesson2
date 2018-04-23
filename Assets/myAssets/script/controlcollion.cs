using UnityEngine;
using System.Collections;

public class controlcollion : MonoBehaviour {
	private bool doorIsClosed = true;
	public AudioClip dooropensound;
	public AudioClip doorclosesound;
	private GameObject door;
	private float time = 0f;
	void Update(){
		if (!doorIsClosed) {
			time += Time.deltaTime;
			if (time >= 3f) {
				closeDoor(door);	
				time = 0f;
			}	
		}
	}
	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.gameObject.tag == "door" && doorIsClosed) {
			door = hit.gameObject;
			openDoor(hit);		
		}

	}
	private void openDoor(ControllerColliderHit hit){
		doorIsClosed = false;
		hit.gameObject.audio.PlayOneShot(dooropensound);	
		hit.transform.parent.animation.Play ("opendoor");
	}
	private void closeDoor(GameObject hit){
		doorIsClosed = true;
		hit.audio.PlayOneShot(doorclosesound);	
		hit.transform.parent.animation.Play ("closedoor");
	}
}
