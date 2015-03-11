using UnityEngine;
using System.Collections;

public class EndSceneEndState : MonoBehaviour {

	public string nextLevel;
	

	//Will load next level if colliding with player
	void OnTriggerEnter(Collider Others)
	{

		if (Others.tag == "LoadPoint") 
			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();	


		if(guiTexture.color.a >= 0.95f)
			Application.LoadLevel(nextLevel);

	}

	IEnumerator LevelLoad(string name){
		yield return new WaitForSeconds(2f);
		Application.LoadLevel(nextLevel);
	}
}
