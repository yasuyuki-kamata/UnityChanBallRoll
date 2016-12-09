using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginChecker : MonoBehaviour
{
	[SerializeField] GameObject BeforeLoginUIPanel;
	[SerializeField] GameObject AfterLoginUIPanel;

	[SerializeField] bool isDebug;

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

	void OnGUI ()
	{
		if (isDebug) {
			if (GUILayout.Button ("Login")) {
				DisplayNCMBPanelAfterLogin ();
			}
			if (GUILayout.Button ("Logout")) {
				DisplayNCMBPanelBeforeLogin ();
			}
		}
	}
}
