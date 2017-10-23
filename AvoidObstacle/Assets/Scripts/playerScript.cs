using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour {
	public float speed;
	public float pPositionX;
	public Animator animator;

	public int score;
	public Text scoreLabel;
	public int hp;
	public Text hpLabel;
	public float time;
	public Text timeLabel;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		pPositionX = transform.position.x;

		score = 0;
		hp = 5;
		time = 30.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Locomotion ();
		pPositionX = this.gameObject.transform.position.x;

		scoreLabel.text = "Score : "+score.ToString();
		hpLabel.text = "HP : "+hp.ToString();
		time -= Time.deltaTime;
		timeLabel.text = "time : "+time.ToString();

		if(hp <= 0){
			//naichilab.RankingLoader.Instance.SendScoreAndShowRanking (100);
			SceneManager.LoadScene("gameOver");
		}
		if(time <= 0){
			SceneManager.LoadScene ("clear");
			//naichilab.RankingLoader.Instance.SendScoreAndShowRanking (score);
		}
	}

	void Locomotion(){
		if (Input.GetKey ("up")) {
			transform.rotation = Quaternion.Euler (0, -90, 0);
			//Debug.Log (pPositionX);
			if(0.4 < pPositionX){
				transform.position += transform.forward * speed*Time.deltaTime;
			}
			animator.SetBool ("isRunning", true);
		} else {
			animator.SetBool ("isRunning", false);
		}
		if (Input.GetKey ("right")) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position += transform.forward * speed*Time.deltaTime;
			animator.SetBool ("isRunning", true);
		}
		if (Input.GetKey ("left")) {
			transform.rotation = Quaternion.Euler (0, 180, 0);
			transform.position += transform.forward * speed*Time.deltaTime;
			animator.SetBool ("isRunning", true);
		}
		if (Input.GetKey ("down")) {
			transform.rotation = Quaternion.Euler (0, 90, 0);
			if(pPositionX < 2.4){
				transform.position += transform.forward * speed*Time.deltaTime;
			}
			animator.SetBool ("isRunning", true);
		}
	}
		
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Obstacle"){
			hp--;

		}else if(col.gameObject.tag == "item"){
			score++;
			Destroy (col.gameObject);
		}
	}
}
