using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class CharacterSelectionController : MonoBehaviour 
{
	public GameObject characterSelectionPanel;
	public GameObject newOneUI;
	public GameObject defaultChara;
	public GameObject newOneChara;
	public GameObject playerObj;
	private GoalChecker goalChecker;

	private Button OldLadyButton;
	// Use this for initialization
	void Awake () 
	{
		OldLadyButton = newOneUI.GetComponent<Button>();
		if (PlayerPrefs.GetInt("OldLadyUnlocked") == 0)
		{
			OldLadyButton.interactable = false;
		}
		else
		{
			OldLadyButton.interactable = true;
		}
		playerObj.SetActive(false);
		defaultChara.SetActive(false);
		newOneChara.SetActive(false);
	}

	void Start()
	{
		GameObject go = GameObject.Find("GoalObj");
		Assert.IsNotNull(go);
		goalChecker = go.GetComponent<GoalChecker>();
		Assert.IsNotNull(goalChecker);
	}
	
	public void DefaultClicked()
	{
		//GameParameters.gameStarted = true;
		Vector3 pos = playerObj.transform.position;
		pos.y -= 0.5f;
		defaultChara.transform.position = pos;
		newOneChara.SetActive(false);
		defaultChara.SetActive(true);
		//Everyplay.StartRecording();
		CommonStart();
	}

	public void NewOneClicked()
	{
		//GameParameters.gameStarted = true;
		Vector3 pos = playerObj.transform.position;
		pos.y -= 0.5f;
		newOneChara.transform.position = pos;
		defaultChara.SetActive(false);
		newOneChara.SetActive(true);
		//Everyplay.StartRecording();
		CommonStart();
	}

	void CommonStart()
	{
		characterSelectionPanel.SetActive(false);
		playerObj.SetActive(true);
		goalChecker.GameStart();
	}
}
