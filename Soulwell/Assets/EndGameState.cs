using UnityEngine;
using System.Collections;

public class EndGameState : MonoBehaviour {
	public string nextLevel;

	void Update () {
	/*
		if(Input.GetKeyDown(KeyCode.F9)){
			Debug.Log("cunt");

			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();

		}
*/

		if (GameObject.FindWithTag("PondCube") == null) {
		
			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();
			if(guiTexture.color.a >= 0.95f)
				Application.LoadLevel (nextLevel);
		}

		}
	IEnumerator LevelLoad(string name){
		yield return new WaitForSeconds(2f);
		Application.LoadLevel(name);
	}
}

