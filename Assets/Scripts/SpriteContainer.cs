using UnityEngine;
using System.Collections;

public class SpriteContainer : MonoBehaviour {
	public Sprite[] pUnarmedWalk, pPunch, pKnifeAttack, pBaseballAttack, pShotgunAttack, pKatanaAttack, pMacheteAttack, pPipeAttack, pPistolAttack, pKnifeWalk, pBaseballWalk, pShotgunWalk, pKatanaWalk, pMacheteWalk, pPipeWalk, pPistolWalk;//3 arrays at the end are new
	public Sprite[] eUnarmedWalk, ePunch, eWalk, eKnifeAttack, eBaseballAttack, eShotgunAttack, eKatanaAttack, eMacheteAttack, ePipeAttack, ePistolAttack, eKnifeWalk, eBaseballWalk, eShotgunWalk, eKatanaWalk, eMacheteWalk, ePipeWalk, ePistolWalk;
	public Sprite enemyKnife, enemyPistol, enemyPipe, enemyMachete, enemyKatana, enemyShotgun, enemyBaseball, enemyUnarmed;
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

	public Sprite[] getPlayerPunch()
	{
		return pPunch;
	}

	public Sprite[] getWeapon(string weapon)
	{
		switch (weapon)
		{
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
		switch (weapon)
		{
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

	public Sprite getEnemySprite(string weapon) //new tut 7
	{	
		if (weapon == "Knife") {
			return enemyKnife;
		} else if (weapon == "Baseball_Bat") {
			return enemyBaseball;
		} else if (weapon == "Shotgun") {
			return enemyShotgun;
		} else if (weapon == "Katana") {
			return enemyKatana;
		} else if (weapon == "Machete") {
			return enemyMachete;
		} else if (weapon == "Steel_Pipe") {
			return enemyPipe;
		} else if (weapon == "Pistol") {
			return enemyPistol;
		} else {
			return enemyUnarmed;
		}
	}

	public Sprite[] getEnemyPunch() //new for tut 8
	{
		return ePunch;
	}

	public Sprite[] getEnemyWeapon(string weapon)
	{
		switch (weapon)
		{
			case "Knife":
				return eKnifeAttack;
				break;
			case "Baseball_Bat":
				return eBaseballAttack;
				break;
			case "Shotgun":
				return eShotgunAttack;
				break;
			case "Katana":
				return eKatanaAttack;
				break;
			case "Machete":
				return eMacheteAttack;
				break;
			case "Steel_Pipe":
				return ePipeAttack;
				break;
			case "Pistol":
				return ePistolAttack;
				break;
			default:
				return getEnemyPunch();
				break;
		}
	}

	public Sprite[] getEnemyWalk(string weapon)
	{
		switch (weapon)
		{
			case "Knife":
				return eKnifeWalk;
				break;
			case "Baseball_Bat":
				return eBaseballWalk;
				break;
			case "Shotgun":
				return eShotgunWalk;
				break;
			case "Katana":
				return eKatanaWalk;
				break;
			case "Machete":
				return eMacheteWalk;
				break;
			case "Steel_Pipe":
				return ePipeWalk;
				break;
			case "Pistol":
				return ePistolWalk;
				break;
			default:
				return eUnarmedWalk;
				break;
		}
	}
}