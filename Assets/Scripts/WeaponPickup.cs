using UnityEngine;
using System.Collections;

public class WeaponPickup : MonoBehaviour {
	public string name;
	public float fireRate;
	public bool gun,oneHanded,shotugn;
	public int ammo;//NEW STUFF FOR 16
	//public AudioClip sfx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D coll) {
		//Debug.Log ("Collision");
		if (coll.gameObject.tag == "Player" && Input.GetMouseButtonDown(1)){
			//code to add weapon to player
			Debug.Log("Player picked up: " + name);//added one handed
			//Destroy (this.gameObject);
			this.gameObject.SetActive (false);
		}
	}
}
