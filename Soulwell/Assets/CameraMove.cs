using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float speed = 1.0f;

	void Update(){

		transform.position = transform.right*Time.deltaTime*speed;
	}

}
