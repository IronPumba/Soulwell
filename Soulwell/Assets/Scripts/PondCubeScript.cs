using UnityEngine;
using System.Collections;

public class PondCubeScript : MonoBehaviour {

	void OnTriggerEnter (Collider info)
	{
		if(info.tag == "Player") renderer.material.color = Color.red;
	}
}
