using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Image LevelSelect;
	public CameraManager cam;
	public List<Button> level = new List<Button>();
	public List<Sprite> levelUnlocked = new List<Sprite>();
	public Sprite locked;
	public bool[] isLocked;

	private void Start()
	{
		isLocked = new bool[level.Count];
		for(int i = 0; i < isLocked.Length; i++)
		{
			if (i == 0)
			{
				isLocked[i] = false;
				level[i].image.sprite = levelUnlocked[i];
			}
			else
			{
				isLocked[i] = true;
				level[i].image.sprite = locked;
			}
		}
	}

	public void Unlock(int i)
	{
		isLocked[i] = false;
	}

	public void Select(int i)
	{
		if (!isLocked[i])
		{
			cam.moveCamera(i);
			LevelSelected();
		}
	}

	private void OnEnable()
	{
		for(int i = 0; i < isLocked.Length; i++)
		{
			if (isLocked[i])
			{
				level[i].image.sprite = locked;
			}
			else
			{
				level[i].image.sprite = levelUnlocked[i];
			}
		}
	}

	public void LevelSelected()
	{
		LevelSelect.canvasRenderer.SetAlpha(1.0f);
		LevelSelect.CrossFadeAlpha(0.0f, 3, false);
	}



	public void ReturnToLevelSelect()
	{
		LevelSelect.canvasRenderer.SetAlpha(0.0f);
		LevelSelect.CrossFadeAlpha(1.0f, 3, false);
	}
}
