using UnityEngine;
using System.Collections;

public class EndGameState : MonoBehaviour {


	void Update () {
	
		if (GameObject.FindWithTag("PondCube") == null) {
			Application.LoadLevel("End Scene");
		}

	}
}
