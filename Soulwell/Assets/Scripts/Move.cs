using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 1.0f;
	
	// Update is called once per frame
	//Moves objects towards playerObject
	void Update () 
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player) 
		{
			Vector3 moveDirection = (player.transform.position - transform.position).normalized;
			transform.position += moveDirection * speed * Time.deltaTime;
		}
	}

}
