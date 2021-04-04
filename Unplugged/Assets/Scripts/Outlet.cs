using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outlet : MonoBehaviour
{
	public Image victory;
	[SerializeField]private GameObject Plug;
	private void OnTriggerEnter(Collider other)
	{
		if (other == Plug.GetComponent<Collider>())
		{
			victory.gameObject.SetActive(true);
		}
	}
}
