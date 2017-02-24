using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public Text txtScore;
	public Text txtAttack;
	public GameObject obtaclePrefab;

	// Use this for initialization
	void Start () {
		DoTestObatacle ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int score = 0;
	int attack = 0;
	public void DoPushButton(){
		score++;
		attack++;
		txtScore.text = "Score : " + score.ToString ();
		txtAttack.text = "Attack : " + attack.ToString ();
	}

	public void DoChangeSceneBack(){
		SceneManager.LoadScene (1);
	}
	public void DoChangeSceneStart(){
		SceneManager.LoadScene (0);
	}
	public void DoTestObatacle(){
		StartCoroutine (GameProcess());
	}

	IEnumerator GameProcess(){
		for (int i = 0; i <= 10; i++) {
			Instantiate (obtaclePrefab);
			yield return new WaitForSeconds (1);
		}
	}
}
