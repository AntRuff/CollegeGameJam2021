using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Image LevelSelect;
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
