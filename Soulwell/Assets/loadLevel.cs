using UnityEngine;
using System.Collections;

public class loadLevel : MonoBehaviour {

	//Used to load the next level
	public string nextLevel;
	
	
	//Will load next level if colliding with player
	void OnTriggerEnter(Collider Others)
	{
		if (Others.tag == "LoadPoint") 
		{
			Application.LoadLevel (nextLevel);		
		}
	}

}
