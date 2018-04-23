using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	public float sp1 = 5f;
	private float sp2;
	private Vector3 v;
	void Start(){
		sp2 = sp1 * 2;
		v = new Vector3 (0, sp2, 0);
	
	}
	// Update is called once per frame
	void Update () {

		rigidbody.velocity = v;
	}
}
