using UnityEngine;
using System.Collections;

public class PondCubeScript : MonoBehaviour {

	private int jumpCount = 0;

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player") jumpCount += 1;

		if(jumpCount >0) renderer.material.color = Color.red;

		if(col.gameObject.tag == "Player")
			{
				audio.Play();
			}

		if(jumpCount >1) Destroy (gameObject);

		if(col.gameObject.tag == "Player") print ("Jumped");


	}
}
