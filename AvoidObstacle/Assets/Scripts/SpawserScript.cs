using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawserScript : MonoBehaviour {
	public GameObject[] obstacle;
	public Vector3 random;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("InstOb", 3f, 1.3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InstOb(){
		for(int i = 0; i < 5; i++){
			//Debug.Log (i);
			random = new Vector3 (Random.Range(-16, -10), 18, Random.Range(-10, 10));
			Instantiate (obstacle[i], random, Quaternion.Euler(90, 0, 0));
		}
	}
}
