using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginChecker : MonoBehaviour
{
	[SerializeField] GameObject BeforeLoginUIPanel;
	[SerializeField] GameObject AfterLoginUIPanel;

	public void DisplayNCMBPanelBeforeLogin()
	{
		BeforeLoginUIPanel.SetActive (true);
		AfterLoginUIPanel.SetActive (false);
	}

	public void DisplayNCMBPanelAfterLogin()
	{
		BeforeLoginUIPanel.SetActive (false);
		AfterLoginUIPanel.SetActive (true);
	}
}
