﻿using UnityEngine;
using System.Collections;

public class PlayerAnimate : MonoBehaviour {
	public Sprite[] walking,attacking;
	int counter = 0;
	PlayerMovement pm;
	float timer = 0.05f,legTimer = 0.05f;
	public SpriteRenderer torso;
	SpriteContainer sc;
	bool attackingB = false;
	// Use this for initialization
	void Start () {
		pm = this.GetComponent<PlayerMovement> ();
		sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SpriteContainer> ();
		walking = sc.getPlayerUnarmedWalk ();
	}
	
	// Update is called once per frame
	void Update () {
		if (attackingB == false) {
			animateTorso ();
		}
	}

	void animateTorso()
	{
		if (pm.moving == true) {
			
			torso.sprite = walking [counter];

			timer -= Time.deltaTime;
			if(timer<=0)
			{
				
					if (counter < walking.Length - 1) {
						counter++;
					} else {
						counter = 0;
					}
					timer = 0.1f;

			}
		} 
	}


	public void resetCounter()
	{
		counter = 0;
		
	}


	public void resetSprites()//new for attacking tut
	{
		counter = 0;
		walking = sc.getPlayerUnarmedWalk ();
		torso.sprite=walking[0];
	}

	public void setNewTorso(Sprite[] walk,Sprite[] attack)
	{
		counter = 0;
		attacking = attack;
		walking = walk;
		torso.sprite = walking [0];//new for attacking tut
	}
}
