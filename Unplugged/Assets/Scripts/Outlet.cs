using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outlet : MonoBehaviour
{
	public Image victory;
	[SerializeField]private GameObject Plug;
	public GamaManager gama;

	private void OnTriggerEnter(Collider other)
	{
		if (other == Plug.GetComponent<Collider>())
		{
			gama.plugs_connected++;
			if (gama.plugs_connected == gama.plug_amounts)
			{
				victory.gameObject.SetActive(true);
				gama.victory();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == Plug.GetComponent<Collider>())
		{
			gama.plugs_connected--;
		}
	}
}
