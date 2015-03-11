using UnityEngine;
using System.Collections;

public class Loadlevel : MonoBehaviour {

	public string nextLevel;

	// Update is called once per frame
	void OnMouseDown(){

		GameObject.Find("Fader").GetComponent<ScreenFade>().FadeToBlack();
		//Application.LoadLevel(nextLevel);
		if(guiTexture.color.a >= 0.95f)
		   // ... reload the level.
		   Application.LoadLevel(nextLevel);

		}
	//IEnumerator LevelLoad(string name){
		//yield return new WaitForSeconds(2f);
		//Application.LoadLevel(nextLevel);
	//}


}
