using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public AudioClip bird;
	private AudioSource source;
	
	bool enter = false;
	
	
	void Start () {
		source = GetComponent<AudioSource>();
		source.clip = bird;
	}
	
	void Update () {
		
	}
	
	void OnTriggerStay(Collider col){
		if (Input.GetKeyDown("f") && col.tag == "Player") {
			if (source.isPlaying) source.Stop();
			else source.Play();
		}
	}
	
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			enter = true;
		}
	}
	
	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			enter = false;
		}
	}
	
	void OnGUI(){
		if(enter){
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 250, 30), "Press 'F'");
		}
	}

}
