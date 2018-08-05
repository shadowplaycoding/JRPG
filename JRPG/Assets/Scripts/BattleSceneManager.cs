using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour {

	public static BattleSceneManager instance;

	public GameObject[] CharacterBattlePrefabs;

	GameObject[] CharacterNodes;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		CharacterNodes = GameObject.FindGameObjectsWithTag("CharacterNode");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnEnterBattle()
	{
		

		for(int i = 0; i < 4; i++)
		{
			GameObject go = GameObject.Instantiate(CharacterBattlePrefabs[i], this.transform);
			go.transform.position = CharacterNodes[i].transform.position + new Vector3(0,2,0);
		}
	}
}
