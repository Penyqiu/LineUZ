using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public Vector3 direction;
    public string creator;
	public GameObject bloodImpact,wallImpact;
	// Use this for initialization
	float timer = 10.0f;


	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (direction*17*Time.deltaTime);

		timer -= Time.deltaTime;
		if(timer<=0)
		{
			Destroy (this.gameObject);
		}
	}

	public void setVals(Vector3 dir, string name)
	{
		direction = dir;
		creator = name;
	}

	void OnCollisionEnter2D(Collision2D col)
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{

	}
}
