using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragMovement : MonoBehaviour
{
	public float zOffset; //Z position to lock the plug to
	public float speed; //How fast does it move

	private Plane plane; //Plane for raycasting
	private float distance; //Distance from raycasting

	private void Start()
	{
		plane = new Plane(Vector3.back, new Vector3(0, 0, zOffset)); //Create an invisable plane
	}

	private void OnMouseDrag()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the camera to the mouse
		if (plane.Raycast(ray, out distance)) // Where on the screen are we dragging to?
		{
			RaycastHit lineHit; // Line cast hit data
			Vector3 destination; // Where are we going?
			if (Physics.Linecast(transform.position, ray.GetPoint(distance), out lineHit)) // Is something in our way?
			{
				destination = lineHit.point; //If so, move to that something
			}
			else
			{
				destination = ray.GetPoint(distance); //Otherwise, go to the mouse position
			}
			GetComponent<Rigidbody>().velocity = (destination - transform.position) * speed; // Move towards the destination
		}
	}

	private void OnMouseUp()
	{
		GetComponent<Rigidbody>().velocity = Vector3.zero;
	}
}
