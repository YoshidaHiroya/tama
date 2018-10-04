using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {
	public int speed;
	// Use this for initialization
	void Start () {
		var force =  new Vector3(1,1,1)   * speed;
		GetComponent<Rigidbody>().AddForce(force,ForceMode.VelocityChange);
		//GetComponent<Rigidbody>().AddForce( force, ForceMode.VelocityChange );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
