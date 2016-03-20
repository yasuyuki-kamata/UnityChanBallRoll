using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class myBallCon : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText;
	public AudioSource pickSnd;
	private int totalItem;
	public bool isComplete;
	public float friction = 0.01f;
	private float moveHorizontal;
	private float moveVertical;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count= 0;
		isComplete = false;
		totalItem = GameObject.FindGameObjectsWithTag("MyItem").Length;
		SetCountText();
	}

	void Update()
	{
		moveHorizontal = Input.GetAxis("Horizontal");
		moveVertical = Input.GetAxis("Vertical");
	}

	void FixedUpdate()
	{
		Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );

		Vector3 vel = rb.velocity;
		if ( vel.magnitude > 0.01f ) {
			vel.Normalize();
			rb.AddForce(vel * -1.0f * friction);
		}
		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if ( other.gameObject.CompareTag("MyItem") ) {
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
			if ( pickSnd ) pickSnd.Play();
			if ( count == totalItem ) isComplete = true;
		}
	}

	void SetCountText()
	{
		countText.text = "Item:" + count.ToString() + "/" + totalItem;
	}
}
