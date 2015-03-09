using UnityEngine;
using System.Collections;

public class PlayerBuddy : MonoBehaviour 
{
	public GameObject target;

	public float followDistance;

	public float travelSpeed;

    public float dampTime;

	public float jumpHeight;

	public Transform lake;

	public float distanceToLake;

	private bool freedom = true;

	public AudioClip bird;

	private AudioSource source;

	// Use this for initialization
	void Start ()
	{
		source = GetComponent<AudioSource>();
		source.clip = bird;
		transform.position = target.transform.position - new Vector3 (2, 2, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(target)
        {
            if(Vector3.Distance(target.transform.position, transform.position) > followDistance && freedom)
            {
				Vector3 dir = target.transform.position - transform.position;
				dir.Normalize();
                transform.position += dir * travelSpeed * Time.deltaTime;
			
            }
			else
			{
				transform.position += transform.forward * 0;
			}
        }

		if(rigidbody.velocity.y == 0 && Input.GetKey(KeyCode.Space))
		{
           
			rigidbody.AddForce (new Vector3 (0, jumpHeight, 0));
		}

		if(Vector3.Distance(lake.transform.position, transform.position) < distanceToLake)
		{
			//race off to the lake 
			freedom = false;
			Vector3 newDir = lake.transform.position - transform.position;
			newDir.Normalize();
			transform.position += newDir * travelSpeed * Time.deltaTime;
		}

		if (Vector3.Distance(lake.transform.position, transform.position) < 0.5f)
		{
			//and disappear
			gameObject.renderer.enabled = false;
			source.Play();
			//if you need to reuse this guy later, then I would suggest //ing out the following line.
			//gameObject.SetActive = false;
		}

	}
}
