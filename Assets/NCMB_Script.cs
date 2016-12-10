using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

[RequireComponent(typeof(LoginChecker))]
public class NCMB_Script : MonoBehaviour
{
	LoginChecker loginChecker;
	[SerializeField] InputField UserName;
	[SerializeField] InputField Password;

	void Start ()
	{
		loginChecker = GetComponent<LoginChecker> ();
		loginChecker.DisplayNCMBPanelBeforeLogin ();
	}

	public void Login ()
	{
		// ログイン処理

		loginChecker.DisplayNCMBPanelAfterLogin ();
	}

	public void Signin ()
	{
		// サインイン処理
		
	}
}
