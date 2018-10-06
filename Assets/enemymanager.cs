using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymanager : MonoBehaviour {
	float time;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 1.0f) {
			Instantiate (enemy, new Vector3(Random.Range(0,20),0,0) , Quaternion.identity);
			time = 0.0f;
		}

	}
}
