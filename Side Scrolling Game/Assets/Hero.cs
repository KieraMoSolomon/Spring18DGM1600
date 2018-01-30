using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {
	public int speed;
	public int speedUp;
	Rigidbody m_Rigidbody;
	// Use this for initialization
	void Start () {
		//int startingLife = 10;
		//int startingLevel = 1;
		//int startingDamage = 2;
		speed = 1;
		speedUp = 5;
		m_Rigidbody = GetComponent<Rigidbody>();
		//powerup boost speed
		//jump- goes up then down maybe in a function
		//if cealing what happens
		//break down into simple thinking
		//jump up does it hit  
	}
	
	// Update is called once per frame
	void Update () {
		Jump();

	}

	//function to get status of health


	//fuction to move side to side


	//function to jump
	void Jump(){
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			m_Rigidbody.velocity = transform.up * speedUp;
		}
	}


	//on right arrow(move to the right)


	//on up arrow(jump then come down)
		//Jump();

	//on colision function?


	//death function
	//Start();

	//
}
