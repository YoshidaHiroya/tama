using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour {
	public int speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position +=  this.transform.forward*speed*Time.deltaTime;
		//this.transform.Rotate(new Vector3(15,40,90)*Time.deltaTime);
			Destroy (gameObject,4);
	}
}

