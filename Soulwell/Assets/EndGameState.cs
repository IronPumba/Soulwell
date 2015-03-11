using UnityEngine;
using System.Collections;

public class EndGameState : MonoBehaviour {


	void Update () {
	/*
		if(Input.GetKeyDown(KeyCode.F9)){
			Debug.Log("cunt");

			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();

		}
*/

		if (GameObject.FindWithTag("PondCube") == null) {
			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();
		}

	}
}
