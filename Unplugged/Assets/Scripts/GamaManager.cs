using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
	public int plug_amounts;// amounts of plugs that need to be connected to beat that level 
	public int plugs_connected = 0; // amount of plugs the player has connected
	public UIManager manage;

	public void startLevel(int i)
	{
		plug_amounts = i;
		plugs_connected = 0;
	}

	public void victory()
	{
		manage.Unlock();
	}
}
