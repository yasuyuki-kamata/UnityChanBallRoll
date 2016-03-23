using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityAnalyticsHeatmap;

public class GameOverController : MonoBehaviour {
	public GameObject gameOverPanel;
	public myCamCon camCon;
	public GameObject iapPanel;

	void Start()
	{
		gameOverPanel.SetActive(false);
	}

	void OnTriggerEnter(Collider other) 
	{
		camCon.isLookAt = true;
		PositionTracker [] objs = GameObject.FindObjectsOfType<PositionTracker>();
		foreach( IAnalyticsDispatcher obj in objs ) 
		{
			obj.DisableAnalytics();
		}
		StartCoroutine(LateOpenRetry());
	}

	IEnumerator LateOpenRetry()
	{
		yield return new WaitForSeconds(2f);
		gameOverPanel.SetActive(true);
	}

	public void ShowIAP()
	{
		iapPanel.SetActive(true);
		gameOverPanel.SetActive(false);
	}

	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void RetryWithEasyMode ()
	{
		GameModeController.setEasyMode ();
		Retry ();
	}
}
