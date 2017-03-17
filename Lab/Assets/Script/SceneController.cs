using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public Text txtScore;
	public Text txtAttack;
	public Text txtLife;
	public GameObject obtaclePrefab;
	public GameObject moneyPrefab;
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		DoTestObatacle ();
		CreateBall ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText ();	
	}

	void UpdateText(){
		txtScore.text = "Score : " + score.ToString ();
		txtLife.text = "Life : " + life.ToString ();
	}

	public static int score = 0;
	int attack = 0;
	public static int life = 5;
	public void DoPushButton(){
		score++;
		attack++;
		txtScore.text = "Score : " + score.ToString ();
		txtAttack.text = "Attack : " + attack.ToString ();
	}

	public void DoChangeScene(){
		SceneManager.LoadScene (1);
	}
	public void DoTestObatacle(){
		StartCoroutine (GameProcess());
	}

	IEnumerator GameProcess(){
		for (int i = 0; i <= 15; i++) {
			GameObject obtacle = Instantiate (obtaclePrefab);
			float positionY = Random.Range (1.0f, 5.58f);
			obtacle.transform.position = new Vector3 (5.58f ,positionY ,0 );

			GameObject money = Instantiate (moneyPrefab);
			money.transform.position = new Vector3 (5.65f, positionY + 0.5f+Random.Range (1.19f, 1.58f), 0);
			yield return new WaitForSeconds (1.2f);
		}
	}

	void CreateBall(){
		Instantiate (ballPrefab).GetComponent<BallController>().SetDieCallBack(CreateBall);
	}
}
