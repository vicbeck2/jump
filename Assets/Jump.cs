using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Jump : MonoBehaviour
{
	public GameObject floor;
	public Vector3 force;
	bool can_jump;

	[DllImport("__Internal")]
	private static extern void Hello();

	void Start()
	{
		Hello();
	}

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

	public void Now ()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
}
