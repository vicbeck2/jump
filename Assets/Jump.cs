using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	public GameObject floor;
	public Vector3 force;
	bool can_jump;

	void Update()
	{
		if (Input.GetMouseButtonDown(0) && can_jump)
		{
			GetComponent<Rigidbody>().AddForce(force);
			can_jump = false;
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject == floor)
		{
			can_jump = true;
		}
	}
}
