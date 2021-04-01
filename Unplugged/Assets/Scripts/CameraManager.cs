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
		moveCamera(startPos);
		FadeFromWhite();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			FadeToWhite();
			levelGroups[curPos].SetActive(false);
			curPos++;
			if (curPos >= positions.Length)
			{
				curPos = 0;
			}
			moveCamera(curPos);
			FadeFromWhite();
		}
	}

	private void FadeToWhite()
	{
		whiteScreen.canvasRenderer.SetAlpha(0.0f);
		whiteScreen.CrossFadeAlpha(1.0f, 3, false);
	}

	private void FadeFromWhite()
	{
		whiteScreen.canvasRenderer.SetAlpha(1.0f);
		whiteScreen.CrossFadeAlpha(0.0f, 3, false);
	}

	private void moveCamera(int element)
	{
		levelGroups[element].SetActive(true);
		Camera.main.transform.position = positions[element].transform.position;
		Camera.main.transform.rotation = positions[element].transform.rotation;
	}
}
