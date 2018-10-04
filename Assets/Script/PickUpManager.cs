using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour {
	public GameObject PickUpprefab; 
	float x,y,z;
	float timeleft;
	// Use this for initialization
	void Start () {
		x = 0;
		y = 0.5f;

	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		if (timeleft <= 0.0) {
			timeleft = 1.0f;
			z += 1;
			Vector3 position = new Vector3(Random.Range(0, 10.0f), Random.Range(0, 20.0f), Random.Range(-3, 10.0f));
			Instantiate (PickUpprefab, position, Quaternion.identity);
		}

	}}
