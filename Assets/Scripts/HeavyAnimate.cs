using UnityEngine;
using System.Collections;

public class HeavyAnimate : MonoBehaviour {

	public SpriteRenderer torso;
	HeavyAI eai;
	SpriteContainer sc;
	public Sprite[] torsoSpr,attackingSpr;


	float torsoTimer=0.15f,torsoReset=0.15f;
	public int tCounter = 0,lCounter = 0;//changed so I can use it to check for attack
	string weapon;
	HeavyAttack ewc;
	public bool attacking = false;
	// Use this for initialization
	void Start () {
		eai = this.GetComponent<HeavyAI> ();
		sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SpriteContainer>();

		ewc = this.GetComponent<HeavyAttack> ();
	}



	// Update is called once per frame
	void Update () {
			if (attacking == true) {
				animateAttack ();
			} else {
				animateWalk ();
			}

			//animateTorso ();
	}

	//add checks for death and counter being above array length
	void animateWalk()
	{
		if (tCounter > torsoSpr.Length - 1) {
			tCounter = 0;
		}
		//Debug.Log ("WALK ANIMATE " + tCounter);
		torsoTimer -= Time.deltaTime;
		if (torsoSpr.Length > 1) {
			torso.sprite = torsoSpr [tCounter];
		} else {
			torso.sprite = torsoSpr [0];
		}

		if(torsoTimer<=0)
		{
			if (tCounter < torsoSpr.Length - 1) {
				tCounter++;
			} else {
				tCounter = 0;
			}
			torsoTimer = torsoReset;
		}
	}

	void animateAttack()
	{
		if (tCounter > attackingSpr.Length - 1) {
			tCounter = 0;
		}

		//Debug.Log ("ATTACK ANIMATE " + tCounter);
		torsoTimer -= Time.deltaTime;
		torso.sprite=attackingSpr[tCounter];

		if(torsoTimer<=0)
		{
			if (tCounter < attackingSpr.Length - 1) {
				tCounter++;
			} else {
				attacking = false;
				tCounter = 0;
			}
			torsoTimer = torsoReset;
		}

	}

	public void setAttacking()
	{
		attacking = true;
	}

	public void resetCounter()
	{
		tCounter = 0;
	}
}
