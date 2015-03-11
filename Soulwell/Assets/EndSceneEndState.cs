using UnityEngine;
using System.Collections;

public class EndSceneEndState : MonoBehaviour {

	

	//Will load next level if colliding with player
	void OnTriggerEnter(Collider Others)
	{

		if (Others.tag == "LoadPoint") 
		{
			GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();		
		}
	
	}
}
