using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKey : MonoBehaviour
{
	public int numerator;
	public Material mat;

	private void Awake()
	{
		GetComponent<Renderer>().material = mat;
	}
}
