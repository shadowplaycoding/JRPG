using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	void Move()
	{
		

		if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
		{
			float distance = Speed * Time.deltaTime;
			float z = Input.GetAxis("Vertical") * distance;
			float x = Input.GetAxis("Horizontal") * distance;

			transform.Translate(x, 0, z);
		}

	}
}
