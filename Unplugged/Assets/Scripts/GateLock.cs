using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLock : MonoBehaviour
{

	public GateKey key;
	public Gate gate;

	private void Start()
	{
		Invoke("SetMat", .5f);
	}

	private void SetMat()
	{
		GetComponent<Renderer>().material = key.GetComponent<Renderer>().material;
		gate.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<GateKey>().numerator == key.numerator)
		{
			gate.openGate();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.GetComponent<GateKey>().numerator == key.numerator)
		{
			gate.closeGate();
		}
	}

}
