using UnityEngine;
using System.Collections;

public class myCamCon : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public bool isLookAt;

	// Use this for initialization
	void Start () {
		offset = this.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if ( isLookAt ) {
			this.transform.LookAt( player.transform.position );
		} else {
			this.transform.position = player.transform.position + offset;
		}
	}
}
