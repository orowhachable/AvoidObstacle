using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankScript : MonoBehaviour {
	public playerScript ps;
	public int score;
	public Text rankLabel;

	// Use this for initialization
	void Start () {
		score = ps.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
