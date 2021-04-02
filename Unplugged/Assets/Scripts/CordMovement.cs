using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordMovement : MonoBehaviour
{

	public GameObject plug;

	public List<Transform> Segments = new List<Transform>();

	public GameObject cordPrefab;

	private Transform curSeg;
	private Transform prevSeg;

	public void Update()
	{
		Segments[0].LookAt(plug.transform);
		float length = Vector3.Distance(plug.transform.position, Segments[0].position);
		Segments[0].Translate(Segments[0].forward * length, Space.World);
		for (int i = 0; i < Segments.Count; i++)
		{
			curSeg = Segments[i];
			prevSeg = Segments[i - 1];
			curSeg.LookAt(prevSeg);
			length = Vector3.Distance(prevSeg.position, curSeg.position);
			curSeg.Translate(curSeg.forward * -1 * length, Space.World);
		}
	}



}
