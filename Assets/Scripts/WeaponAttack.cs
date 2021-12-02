using UnityEngine;
using System.Collections;

public class WeaponAttack : MonoBehaviour {
	public GameObject oneHandSpawn,twoHandSpawn,bullet,shotgunBullet;
	GameObject curWeapon;
	public bool gun = false;
	float timer = 0.1f,timerReset=0.1f;
	PlayerAnimate pa;
	SpriteContainer sc;

	float weaponChange = 0.5f;
	bool changingWeapon = false;
	bool oneHanded = false;



	//NEW STUFF FOR 16
	bool Shotgun = false;

	public GUIStyle text;
	float originalWidth = 1920.0f;
	float originalHeight = 1080.0f;
	Vector3 scale;
	public Texture2D bg;
	public WeaponPickup curWepScr;

	void Start () {
		pa = this.GetComponent<PlayerAnimate> ();
		sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SpriteContainer> ();
	}
	

	void Update () {
		

		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if(Input.GetMouseButton(0) && timer<=0)
		{
			attack ();
		}
		if(Input.GetMouseButtonDown(0))
		{
			pa.resetCounter ();
		}
		if (Input.GetMouseButtonUp (0)) {
			pa.resetCounter ();
		}
		if (curWeapon == null) {

		}

		if(changingWeapon==true)
		{
			weaponChange -= Time.deltaTime;
			if(weaponChange<=0)
			{
				changingWeapon = false;
			}
		}
	}

	/*public void setWeapon(GameObject cur, string name, float fireRate,bool gun,bool oneHanded,bool shotgun)
	{
		changingWeapon = true;

		pa.setNewTorso (sc.getWeaponWalk(name),sc.getWeapon(name));
		this.gun = gun;
		timerReset = fireRate;
		timer = timerReset;
		this.oneHanded = oneHanded;
		Shotgun = shotgun;

		//changed to get rid of null reference errors
		if (cur == null) {

		} else {
			curWeapon = cur;
			curWepScr = curWeapon.GetComponent<WeaponPickup> ();//NEW STUFF FOR 16

		}
	}*/

	public void attack()
	{
		
		if (gun == true && curWepScr.ammo > 0) {//NEW STUFF FOR 16
			pa.attack ();
			Bullet bl = bullet.GetComponent<Bullet> ();
			Vector3 dir;
			dir.x = Vector2.right.x;
			dir.y = Vector2.right.y;
			dir.z = 0;
			bl.setVals (dir,"Player");

				if (oneHanded == true) {
					if (Shotgun == false) {//new for new weapons
						Instantiate (bullet, oneHandSpawn.transform.position, this.transform.rotation);
					} else {
						Instantiate (shotgunBullet, oneHandSpawn.transform.position, this.transform.rotation);
					}
					curWeapon.GetComponent<WeaponPickup> ().ammo--;
				} else {
					if (Shotgun == false) {//new for new weapons
						Instantiate (bullet, twoHandSpawn.transform.position, this.transform.rotation);
					} else {
						Instantiate (shotgunBullet, twoHandSpawn.transform.position, this.transform.rotation);
					}
					curWeapon.GetComponent<WeaponPickup> ().ammo--;
				}
			timer = timerReset;

			//if (Input.GetMouseButtonUp (0)) {
				//pa.resetCounter ();
			//}

		} else if(gun == true && curWepScr.ammo == 0)
		{
			//NEW STUFF FOR 16
		}
		else{
			
			pa.attack ();//NEW STUFF FOR 16
			//melee attack
			int layerMask = 1<<9;
			layerMask = ~layerMask;
			pa.attack ();
			RaycastHit2D ray = Physics2D.Raycast (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),1.5f,layerMask);
			Debug.DrawRay (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),Color.green);

			timer = timerReset;
		}


	}

	public GameObject getCur()
	{
		return curWeapon;
	}

	void OnGUI() //NEW STUFF FOR 16
	{
		GUI.depth = 0;
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z =1;
		var svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,scale);

		if (gun == true && CutsceneDisplay.anyCutsceneDisplaying==false) {//new condition for 20/21?
			Rect posForAmmo = new Rect (originalWidth-535,originalHeight-200,300,150);
			GUI.DrawTexture (posForAmmo, bg);
			posForAmmo = new Rect (originalWidth-500,originalHeight-150,300,150);
			GUI.Box (posForAmmo, "Ammo: " + curWeapon.GetComponent<WeaponPickup> ().ammo, text);
		}

		GUI.matrix = svMat;
	}
}
