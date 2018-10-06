using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller1 : MonoBehaviour {
	public int speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (speed*Time.deltaTime,0,0);
		if(this.transform.position.x>25.0f){
			Destroy (gameObject);
	}
}
}
