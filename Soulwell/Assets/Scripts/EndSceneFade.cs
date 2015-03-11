using UnityEngine;
using System.Collections;

public class EndSceneFade : MonoBehaviour {

	Color test;
	//Used to load the next level
	public string nextLevel;
	public float fadeSpeed = 0.1f;          // Speed that the screen fades to and from black.
	
	private bool sceneStarting = true, endingScene = false;      // Whether or not the scene is still fading in.
	
	
	void Awake ()
	{
		test = Color.black;
		
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}
	
	
	void Update ()
	{
		if(guiTexture.color == Color.black){
			Application.LoadLevel(nextLevel);
		}
		
		if (endingScene)
			// ... call the StartScene function.
			//FadeToBlack();
			EndScene ();
		// If the scene is starting...
		if(sceneStarting)
			// ... call the StartScene function.
			StartScene();
	}
	
	
	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	public void FadeToBlack ()
	{
		endingScene = true;
		// Lerp the colour of the texture between itself and black.
		guiTexture.color += Color.Lerp (guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);//guiTexture.color.a, test.a , fadeSpeed * Time.time);
		Debug.Log ("dont call me cunt");
		
	}
	
	
	void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(guiTexture.color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			
			// The scene is no longer starting.
			sceneStarting = false;
		}
	}
	
	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		guiTexture.enabled = true;
		
		// Start fading towards black.
		FadeToBlack();

		// If the screen is almost black...
		if(guiTexture.color.a >= 0.95f)
			
			// ... reload the level.
			Application.LoadLevel(nextLevel);
	}

	

}
