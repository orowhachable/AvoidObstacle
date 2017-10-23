using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour {
	public GameObject item;
	public Vector3 random;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("InstItem", 3f, 1.3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InstItem(){
		random = new Vector3 (Random.Range(-16, -10), 18, Random.Range(-10, 10));
		// Instantiate (item, random, Quaternion.Euler(90, 0, 0));
		Instantiate (item, random, Quaternion.identity);
		// Debug.Log ("");
	}
}
