using UnityEngine;
using System.Collections;

public class lightcontrol : MonoBehaviour
{
    RaycastHit hit;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if (hit.collider.gameObject.tag == "door")
            {
                hit.collider.gameObject.SendMessage("openDoor");
                print(hit.collider.gameObject.tag);
            }
        }
	}
}
