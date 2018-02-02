using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {
	public int speed;
	public int speedUp;
	public int jumpCounter;
	Rigidbody m_Rigidbody;
	public bool grounded;
	// Use this for initialization
	void Start () {
		//int startingLife = 10;
		//int startingLevel = 1;
		//int startingDamage = 2;
		speed = 1;
		speedUp = 5;
		m_Rigidbody = GetComponent<Rigidbody>();
		grounded = true;
		jumpCounter = 2;
		//powerup boost speed
		//jump- goes up then down maybe in a function
		//if cealing what happens
		//break down into simple thinking
		//jump up does it hit  
		
		
		//CharacterController controller = GetComponent<CharacterController>();
		//if(controller.isGrounded){
		//	print("We are grounded");
		//}
	}
	
	// Update is called once per frame
	void Update () {
		Jump();
		HeroMovement();

	}

	//function to get status of health


	//fuction to move side to side
	void HeroMovement(){
		if(Input.GetKey(KeyCode.RightArrow)){
			//Vector3 position = this.transform.position;
			//position.x++;
			//this.transform.position = position;
			//flip to look to the right
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			//flip to look left
			transform.position -= Vector3.right * speed * Time.deltaTime;
		}
	}

	//function to jump
	void Jump(){

		if(grounded && Input.GetKeyDown(KeyCode.UpArrow)){
			while(jumpCounter > 0){
					m_Rigidbody.velocity = transform.up * speedUp;

					//double jump limit
					jumpCounter --;
			}
		}
		else{
			//jumpCounter = 2;
		}
	
	}

	//function to crawl



	//on colision function?


	//death function(){
	//}
	//restart function(){
	//Start();
	//}

}
