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



	// Use this for initialization
	void Start () 
	{
		transform.position = target.transform.position - new Vector3 (-2, -2, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(target)
        {
            if(Vector3.Distance(target.transform.position, transform.position) > followDistance)
            {
                transform.position += transform.forward * travelSpeed * Time.deltaTime;

            }
			else
			{
				transform.position += transform.forward * travelSpeed * 0;
			}
        }

		if(rigidbody.velocity.y == 0 && Input.GetKey(KeyCode.Space))
		{
           
			rigidbody.AddForce (new Vector3 (0, jumpHeight, 0));
		}

		if(Vector3.Distance(lake.transform.position, transform.position) < distanceToLake)
		{
			//race off to the lake and disappear
		}
	}
}
