using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outlet : MonoBehaviour
{ 
	//
	public Image victory;
	public bool plugged_in = false;
	public GamaManager GM_script;
	[SerializeField]private MouseDragMovement Plug; // Outlet interacts with 
	private void OnTriggerEnter(Collider other)
	{
		if (other == Plug.GetComponent<Collider>() && !plugged_in)
		{
			plugged_in = true;
			GM_script.plugs_connected++;
			Plug.gameObject.transform.parent = gameObject.transform; // This parents the outlet keeping in one place after it's connected with the outlet
		}
	}

	private void Update()
	{
		if (GM_script.plugs_connected == GM_script.plug_amounts)  
		{
			victory.gameObject.SetActive(true);
		}
	}

    private void Start()
    {
        
    }
}
