using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLock : MonoBehaviour
{

	public GateKey key;
	public Gate gate;

	private void Start()
	{
		GetComponent<Renderer>().material = key.mat;
		gate.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<GateKey>().numerator == key.numerator)
		{
			gate.openGate();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.GetComponent<GateKey>().numerator == key.numerator)
		{
			gate.closeGate();
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		
	}


}
