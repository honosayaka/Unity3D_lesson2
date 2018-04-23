using UnityEngine;
using System.Collections;

public class cellRoute : MonoBehaviour {
    public AudioClip co;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,4,0);
	}

    void OnTriggerEnter(Collider col) {
        if (col.collider.gameObject.tag == "player")
        {
            //      gameObject.audio.PlayOneShot(co);
            AudioSource.PlayClipAtPoint(co,transform.position);
             col.collider.transform.SendMessage("pickCell");
                Destroy(gameObject);
        }
       
    }
}
