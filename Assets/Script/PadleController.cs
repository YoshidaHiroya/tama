using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadleController: MonoBehaviour {
	public float speed; // 動く速さ

	public int jumpcount;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		var moveHorizontal = Input.GetAxis("Horizontal");
		rb.velocity = new Vector3(moveHorizontal*speed, 0,0);
	}
}
