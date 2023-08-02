using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class Jump : MonoBehaviour
{
	public GameObject floor;
	public Vector3 force;
	bool can_jump;
	public Text log;
	public Text chain;

	void Start()
	{
		Web3.Initialize();
		Web3.Connect();
		Web3.SwitchNetwork("0x5");
		Web3.OnAccountChange += Log;
		Web3.OnChainChange += ChainChange;
	}

	public void Log (string text)
	{
		log.text = text;
	}

	public void ChainChange (string text)
	{
		chain.text = text;
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
