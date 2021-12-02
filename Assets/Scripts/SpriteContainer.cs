using UnityEngine;
using System.Collections;

public class SpriteContainer : MonoBehaviour {
	public Sprite[] pUnarmedWalk,pPunch, pKnifeAttack, pBaseballAttack, pShotgunAttack, pKatanaAttack, pMacheteAttack, pPipeAttack, pPistolAttack, pKnifeWalk, pBaseballWalk, pShotgunWalk, pKatanaWalk, pMacheteWalk, pPipeWalk,pPistolWalk; //Unused weapons - no animations
	// Use this for initialization //3 arrays at the end are new
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Sprite[] getPlayerUnarmedWalk()
	{
		return pUnarmedWalk;
	}

	public Sprite[] getPlayerPunch()
	{
		return pPunch;
	}

	public Sprite[] getWeapon(string weapon)
	{
		switch (weapon) {
		case "Knife":
			return pKnifeAttack;
			break;
		case "Baseball_Bat":
			return pBaseballAttack;
			break;
		case "Shotgun":
			return pShotgunAttack;
			break;
		case "Katana":
			return pKatanaAttack;
			break;
		case "Machete":
			return pMacheteAttack;
			break;
		case "Steel_Pipe":
			return pPipeAttack;
			break;
		case "Pistol":
			return pPistolAttack;
			break;
		default:
			return getPlayerPunch();
			break;
		}
	}

	public Sprite[] getWeaponWalk(string weapon)
	{
		switch (weapon) {
		case "Knife":
			return pKnifeWalk;
			break;
		case "Baseball_Bat":
			return pBaseballWalk;
			break;
		case "Shotgun":
			return pShotgunWalk;
			break;
		case "Katana":
			return pKatanaWalk;
			break;
		case "Machete":
			return pMacheteWalk;
			break;
		case "Steel_Pipe":
			return pPipeWalk;
			break;
		case "Pistol":
			return pPistolWalk;
			break;
		default:
			return getPlayerUnarmedWalk();
			break;
		}
	}

}
