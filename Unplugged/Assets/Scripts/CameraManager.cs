using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	public int startPos;
	public Image whiteScreen;
	private int curPos;
	public GameObject[] positions;
	public GameObject[] levelGroups;

	private void Start()
	{
		curPos = startPos;
		foreach (GameObject level in levelGroups){
			level.SetActive(false);
		}
		FadeFromWhite();
	}

	public int GetCurPos()
	{
		return curPos;
	}
	public void FadeToWhite()
	{
		whiteScreen.gameObject.SetActive(true);
		whiteScreen.canvasRenderer.SetAlpha(0.0f);
		whiteScreen.CrossFadeAlpha(1.0f, 3, false);
		levelGroups[curPos].SetActive(false);
		
	}

	public void FadeFromWhite()
	{
		
		whiteScreen.canvasRenderer.SetAlpha(1.0f);
		whiteScreen.CrossFadeAlpha(0.0f, 3, false);
		whiteScreen.gameObject.SetActive(false);
	}

	public void moveCamera(int element)
	{
		FadeToWhite();
		levelGroups[curPos].SetActive(false);
		curPos = element;
		levelGroups[element].SetActive(true);
		Camera.main.transform.position = positions[element].transform.position;
		Camera.main.transform.rotation = positions[element].transform.rotation;
		FadeFromWhite();
	}
}
