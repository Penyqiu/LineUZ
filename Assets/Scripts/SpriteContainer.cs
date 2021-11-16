using UnityEngine;
using System.Collections;

public class SpriteContainer : MonoBehaviour {
	public Sprite[] pUnarmedWalk;//3 arrays at the end are new
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Sprite[] getPlayerUnarmedWalk()
	{
		return pUnarmedWalk;
	}



}
