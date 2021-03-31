using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
	private bool isOpen = false;
	public float closePos;
	public float speed;
	private Vector3 openVec;
	private Vector3 dest;
	private Vector3 closeVec;

	private void Start()
	{
		openVec = new Vector3(transform.position.x, closePos-2, transform.position.z);
		closeVec = new Vector3(transform.position.x, closePos, transform.position.z);
		dest = closeVec;
	}

	public void openGate()
	{
		isOpen = true;
		Debug.Log("Open");
		dest = openVec;
	}

	public void closeGate()
	{
		isOpen = false;
		Debug.Log("Close");
		dest = closeVec;
	}

	private void Update()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, dest, step);
	}
}
