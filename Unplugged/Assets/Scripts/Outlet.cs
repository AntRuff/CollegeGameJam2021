using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outlet : MonoBehaviour
{
	public Image victory;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<MouseDragMovement>())
		{
			victory.gameObject.SetActive(true);
		}
	}
}
