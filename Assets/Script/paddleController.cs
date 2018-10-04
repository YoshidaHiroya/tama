﻿using UnityEngine;

public class paddleController : MonoBehaviour
{
	public float accel = 1000;

	private void Update()
	{
		var force = transform.right * Input.GetAxisRaw( "Horizontal" ) * accel;
		GetComponent<Rigidbody>().AddForce( force, ForceMode.Impulse );
	}
}