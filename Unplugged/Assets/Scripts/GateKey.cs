using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKey : MonoBehaviour
{
	public int numerator;
	public Material mat;

	private void Start()
	{
		GetComponent<Renderer>().material = mat;
	}
}
