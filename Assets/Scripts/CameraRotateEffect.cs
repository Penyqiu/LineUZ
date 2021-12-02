using UnityEngine;
using System.Collections;

public class CameraRotateEffect : MonoBehaviour {
	PlayerMovement pm;
	float mod=0.1f;
	float zVal=0.0f;
	// Use this for initialization
	void Start () {
		pm = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();
	}

	// Update is called once per frame
	void Update () {
		if(pm.moving==true)
		{
			Vector3 rot = new Vector3 (0, 0, zVal);
			this.transform.eulerAngles = rot;

			zVal += mod;

			if (transform.eulerAngles.z >= 5.0f && transform.eulerAngles.z < 7.0f) {
				mod = -0.1f;
			}
			else if (transform.eulerAngles.z <355.0f && transform.eulerAngles.z > 353.0f) {
				mod = 0.1f;
			}


		}
	}
}
