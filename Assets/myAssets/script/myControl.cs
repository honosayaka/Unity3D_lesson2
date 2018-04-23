using UnityEngine;
using System.Collections;

public class myControl : MonoBehaviour {

	private float moveSpeed = 3f;
//	private bool isGround = false;
	private float jumpSpeed = 3f;
	private float gravity = 20f;
	private CharacterController controller;
	private Vector3 direction;
//	private CollisionFlags flag;
	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<CharacterController> ();
		direction = Vector3.zero;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (controller.isGrounded) {
			direction.x = Input.GetAxis("Horizontal") * moveSpeed;
			direction.z = Input.GetAxis("Vertical") * moveSpeed;//get the keyboard input
		//	transform.TransformDirection(direction);//start transform#!!!!you is not haveto add this sentence
			if(Input.GetButton("Jump")){
				direction.y = jumpSpeed;	//detect the blank button to jump		
			}	
		}
		direction.y -= gravity*Time.deltaTime;//go back to the ground
	//	flag = controller.Move (direction * moveSpeed);//start to move
		controller.Move (direction * moveSpeed);
		/*
		var flags=controller.Move(movedirection*Time.deltaTime);
		//CollisionFlags.CollidedBelow    底部发生了碰撞“flags & CollisionFlags.CollidedBelow”返回1
		//CollisionFlags.CollidedNone   没发生碰撞“flags & CollisionFlags.CollidedNone”返回1
		//CollisionFlags.CollidedSides    四周发生了碰撞“flags & CollisionFlags.CollidedSides”返回1
		//CollisionFlags.CollidedAbove   顶端发生了碰撞“flags & CollisionFlags.CollidedAbove”返回1
		// 单个& 表示比较两个二进制数值
		//位掩码技术
		grounded=(flags & CollisionFlags.CollidedBelow)!=0;  
		 */
		//	isGround = (flag & CollisionFlags.CollidedBelow)!=0;//detect is in ground #!and it is not necessary too!can use controll.isGrounded instead;
	}
}
